using System;
using System.Collections.Generic;

namespace XamarinFormDemo
{
	public class PersonEx
	{
		public PersonEx ()
		{
		}

		public string Name{ get; set; }
        public string NickName{ get; set; }
        public string Biography{ get; set; }
		public int Age{ set; get; }

		public override string ToString ()
		{
			return string.Format ("{0}, {1}", Name, Age);
		}

        static public List<PersonEx> Get()
		{
            var persons = new List<PersonEx> ();
            persons.Add (new PersonEx {
				Name = "Joe",
				Age = 20,
                NickName = "Joe's nick name",
                Biography = "Joe's biography"
			});

            persons.Add (new PersonEx {
				Name = "Mary",
				Age = 30,
                NickName = "Mary's nick name",
                Biography = "Mary's biography"
			});

            persons.Add (new PersonEx {
				Name = "Sam",
				Age = 24,
                NickName = "Sam's nick name",
                Biography = "Sam's biography"
			});

			persons.Add (new PersonEx {
				Name = "Gary",
				Age = 40,
                NickName = "Gary's nick name",
                Biography = "Gary's biography"  
			});

            persons.Add (new PersonEx {
				Name = "Gilbert",
				Age = 28,
                NickName = "Gilbert's nick name",
                Biography = "Gilbert's biography"
			});

            persons.Add (new PersonEx {
				Name = "Gerry",
				Age = 38,
                NickName = "Gerry's nick name",
                Biography = "Gerry's biography"
			});

			return persons;

		}
	}
}

