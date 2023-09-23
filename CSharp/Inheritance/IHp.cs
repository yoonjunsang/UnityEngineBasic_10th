namespace Inheritance
{
    // interface : 기능을 추상화하는 사용자정의 자료형
    // naming : 대문자 I + PascalCase 
    internal interface IHp
    {
        float hpValue { get; }
        float hpMax { get; }
        float hpMin { get; }

        void RecoverHp(object subject, float amount);
        void DepleteHp(object subject, float amount);
    }
}
