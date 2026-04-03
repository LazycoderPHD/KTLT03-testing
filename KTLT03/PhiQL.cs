using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT03
{
    public class PhiQL
    {
        protected string idQL;
        protected int monthQL;
        protected int yearQL;

        public string IdQL
        {
            get { return this.idQL; }
            set
            {
                if (value.Length > 3)
                {
                    this.idQL = value;
                }
                else
                {
                    this.idQL = "NoId";
                }
            }
        }

        public int MonthQL
        {
            get { return this.monthQL; }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    this.monthQL = value;
                }
                else
                {
                    this.monthQL = 1;
                }
            }
        }

        public int YearQL
        {
            get { return this.yearQL; }
            set
            {
                if (value >= 2000)
                {
                    this.yearQL = value;
                }
                else
                {
                    this.yearQL = DateTime.Now.Year;
                }
            }
        }
    }
        
}
