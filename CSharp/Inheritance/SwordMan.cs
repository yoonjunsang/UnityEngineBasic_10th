namespace Inheritance
{
    internal class SwordMan : PlayableCharacter
    {
        private int _swordMasteryLevel;

        // override : 재정의 키워드
        // 기반타입의 멤버를 재정의 할때 사용하는 키워드
        public override void Move()
        {
            Console.WriteLine("Move");
        }

        public void Smash()
        {
            Console.WriteLine("Smash");
        }
    }
}
