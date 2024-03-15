using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class UserCard<T, K> //where T: Decoder where K : class // конкретизация
    {
        public T Id { get; set; }
        private K userCode;
        public string userName;

        public UserCard(T Id, K userCode)
        {
            this.Id = Id;
            this.userCode = userCode;
        }

        public static void Test<L>(L? number, L? scnNumber)
        {
            (number, scnNumber) = (scnNumber, number);
        }
    }

    class NoneGenericUserCard
    {
        public int Id { get; set; }
        private string userCode;
        public string userName;

        public NoneGenericUserCard(int Id, string userCode)
        {
            this.Id = Id;
            this.userCode = userCode;
        }

        public void Test<T>()
        {

        }
    }
}
