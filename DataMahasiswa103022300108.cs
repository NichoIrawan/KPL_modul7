using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103022300108
{
	public class Mahasiswa()
	{
		
		public string firstName {  get; set; }
		public string lastName {  get; set; }
		public string gender { get; set; }
		public int age { get; set; }
		public Address address { get; set; }

        public List<Course> courses { get; set; }
    }


	public class Address()
	{
		public string streetAddress { get; set; }
		public string city { get; set; }
		public string state { get; set; }
	}

	public class Course()
	{
		public string code { get; set; }
		public string name { get; set; }
	}

	public static void ReadJSON()
	{
		string json = File.ReadAllText("..//..//..//jurnal7_1_103022300108.json");
		var mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(json);
		Console.WriteLine("Nama Mahasiswa: " + mahasiswa.firstName + " " + mahasiswa.lastName);
		Console.WriteLine("Gender: " + mahasiswa.gender);
		Console.WriteLine("Umur: " + mahasiswa.age);
		Console.WriteLine("Alamat: " + mahasiswa.address.streetAddress + " " + mahasiswa.address.city + " " + mahasiswa.address.state);
		Console.WriteLine("Courses: ");
		for (int i = 0; i < mahasiswa.courses.Count; i++) {
			Console.WriteLine(mahasiswa.courses.ElementAt(i).code + " " + mahasiswa.courses.ElementAt(i).name);
		}


	}
}
