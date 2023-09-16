using A; // using 어떤 namespace 를 갖다 쓰겠다고 명시하는 키워드
using Tester;
using Program = A.Program; // 어떤 네임스페이스의 클래스를 디폴트로 사용하겠다고 명시하는 구문

internal class Dummy
{
    void Test()
    {
        Program program = new Program();
    }
}