using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Sealed_
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            this.CreateDate = DateTime.Now;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual void SetLog() { }
        public virtual void GetLog() { }
        public virtual void GetCurrentUser() { }

        public class Personel : BaseClass
        //Personel new lendiği anda BaseSclassdan kalıtılsın ve BaseClass oluştuğunda da "this.CreateDate = DateTime.Now;" çalışsın.
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName
            {
                get
                {
                    return this.FirstName + " " + this.LastName;
                }
            }
            public sealed override void GetLog()
            {
                base.GetLog();
            }
            public override void SetLog()
            {
                base.SetLog();
            }
            public override void GetCurrentUser()
            {
                base.GetCurrentUser();
            }
        }

        public sealed class Yonetici : Personel
            //Yönetici son noktadır. Sadece instance oluşturmaya izin verilir. Yöneticiden kalıtım yapılamaz olur.
        {
        }
    }
}
