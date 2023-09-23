namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PlayableCharacter playableCharacter = new PlayableCharacter();
            PlayableCharacter swordMan = new SwordMan();
            swordMan.Move();


            // 공변성 (Covariant)
            // 하위타입 객체를 기반타입으로 참조할 수 있는 성질.
            // 객체가 할당될 때, 기반타입의 데이터부터 차례대로 할당을 하기 때문에 가능함.
            PlayableCharacter swordMan1 = new SwordMan();
            PlayableCharacter wizard1 = new Wizard();
            PlayableCharacter intermidiateWizard1 = new IntermidiateWizard();
            swordMan.Move();
            swordMan1.Move();
            wizard1.Move();
            intermidiateWizard1.Move();



            // object 타입
            // C# 의 모든 타입의 기반타입

            // Boxing : 
            // object 타입 변수에 어떤 데이터를 대입하면 
            // heap 메모리영역에 object 타입 객체를 생성하고, 
            // 데이터의 타입참조테이블인덱스와 데이터를 씀.
            object int1 = 3;
            object str = "zㅣ존검사";
            object wizard = new Wizard();

            // Unboxing :
            // object 객체에서 원래 데이터를 읽어오는 과정
            int a = (int)int1;

        }
    }
}