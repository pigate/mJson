Usage:

JsonSimpleObject j = new JsonSimpleObject();

j.AddBool("faulty", true);

j.AddInt("age", 2);

j.AddInt("weight", 4);

j.AddDec("height", (decimal)4.4);

j.AddLong("length", (long)6.0);

j.AddString("mood", "happy");

j.AddChar("wasted?", 'c');

j.AddDateTime("bday", new DateTime(1, 1, 1));

Console.WriteLine(j.ToString());

