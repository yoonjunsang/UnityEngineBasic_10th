namespace Inheritance
{
    internal interface IAttacker
    {
        float attackPower { get; }
        float criticalGain { get; }


        void Attack(IHp target, bool isCritical);
    }
}
