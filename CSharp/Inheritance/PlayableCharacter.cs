namespace Inheritance
{
    internal abstract class PlayableCharacter : IHp, IAttacker
    {
        public float hpValue
        {
            get
            {
                return _hp;
            }
            private set
            {
                if (value == _hp)
                    return;

                if (value > hpMax)
                    value = hpMax;
                else if (value < hpMin)
                    value = hpMin;

                _hp = value;
            }
        }

        public float hpMax
        {
            get
            {
                return _hpMax;
            }
        }

        public float hpMin
        {
            get
            {
                return 0.0f;
            }
        }

        public float attackPower
        {
            get
            {
                return _attackPower;
            }
        }

        public float criticalRatio
        {
            get
            {
                return _criticalRatio;
            }
        }

        public float criticalGain
        {
            get
            {
                return _criticalGain;
            }
        }

        private float _hp;
        private float _hpMax;
        private float _attackPower;
        private float _criticalGain;

        public virtual void Breath()
        {

        }

        public abstract void Move();

        public void Attack(IHp target, bool isCritical)
        {
            target.DepleteHp(this, isCritical ? _attackPower * _criticalGain : _attackPower);
            
            if (target is PlayableCharacter)
            {
                ((PlayableCharacter)target).DepleteHp<PlayableCharacter>(this, isCritical ? _attackPower * _criticalGain : _attackPower);
            }
        }

        // Generic 타입
        // 타입을 미리 정의해놓는게 아니라, 특정 타입에따라 다른 정의를 할 수 있도록 
        // 그 형태만 정의해놓는 타입
        // 특징은 컴파일타임에, 특정 타입을 명시해놓고 이 Generic타입을 쓰는 코드가 있으면 
        // 컴파일러가 그 정의를 만들어서 빌드에 추가함.

        // PlayableCharacter 타입으로 사용하는 코드가 있다면, 아래 정의를 컴파일타임에 추가함.
        //public void DepleteHp(PlayableCharacter subject, float amount)
        //{
        //    hpValue -= amount;
        //}
        public void DepleteHp<T>(T subject, float amount)
        {
            hpValue -= amount;
        }

        public void DepleteHp(object subject, float amount)
        {
            hpValue -= amount;
        }

        public void RecoverHp(object subject, float amount)
        {
            hpValue += amount;
        }
    }
}
