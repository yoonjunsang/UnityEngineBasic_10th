namespace Delegates
{
    public class Content
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Youtuber
    {
        private Content[] _contents = new Content[100];
        private int _coutentsCount;
        public delegate void OnContentUploadedHandler(Content content); // 대리자 타입 정의

        // event 한정자 
        // 외부에서는 이 대리자의 += 과 -= 만 사용가능하도록 제한.
        public event OnContentUploadedHandler OnContentUploaded; // 대리자선언

        public void UploadContent(Content content)
        {
            _contents[_coutentsCount++] = content;
            OnContentUploaded(content);
        }
    }

    public class Subscriber : INotifyContent
    {
        public string name;

        public void Subscribe(Youtuber youtuber)
        {
            youtuber.OnContentUploaded += Notification; // 구독하기
        }

        public void CancelSubscription(Youtuber youtuber)
        {
            youtuber.OnContentUploaded -= Notification; //구독 취소하기
        }

        public void Notification(Content content)
        {
            Console.WriteLine($"{name} 님 ! {content.Name} 이 새로 업로드 되었어요..!");
        }
    }

    public class ContentQA : INotifyContent
    {
        public void Notification(Content content)
        {
            Console.WriteLine($"{content.Name} 이 업로드 되었으니 검수하세요..!");
        }
    }

    public class Manager
    {
        public void OnContentUploaded(Content content)
        {

        }
    }


    public interface INotifyContent
    {
        void Notification(Content content); 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Youtuber youtuber = new Youtuber();
            Subscriber subscriber1 = new Subscriber();
            Subscriber subscriber2 = new Subscriber();
            Subscriber subscriber3 = new Subscriber();
            Subscriber subscriber4 = new Subscriber();

            subscriber1.Subscribe(youtuber);
            subscriber4.Subscribe(youtuber);
            subscriber2.Subscribe(youtuber);
            subscriber3.Subscribe(youtuber);

            youtuber.UploadContent(new Content());
        }
    }
}