namespace Inheritance
{
    internal class Wizard : PlayableCharacter
    {
        public override void Breath()
        {
            base.Breath();
            // todo -> 마나 호흡 추가
        }

        public override void Move()
        {
            Console.WriteLine("Move");
        }

        public void Fireball()
        {
            Console.WriteLine("Fireball");
        }
    }
}
