using System;
using System.Collections.Generic;

namespace XamarinFormDemo
{
	class Person
	{
		public Person ()
		{
		}

		public string Name{ get; set; }
		public int Age{ set; get; }

		public override string ToString ()
		{
			return string.Format ("{0}, {1}", Name, Age);
		}

		static public Person[] Get()
		{
			var persons = new List<Person> ();
			persons.Add (new Person {
				Name = "Joe",
				Age = 20
			});

			persons.Add (new Person {
				Name = "Mary",
				Age = 30
			});

			persons.Add (new Person {
				Name = "Sam",
				Age = 24
			});

			persons.Add (new Person {
				Name = "Gary",
				Age = 40
			});

			persons.Add (new Person {
				Name = "Gilbert",
				Age = 28
			});

			persons.Add (new Person {
				Name = "Gerry",
				Age = 38
			});

			return persons.ToArray ();

		}
	}
}

