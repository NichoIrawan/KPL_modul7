using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103022300010
{
	public class Mahasiswa()
	{
		public Course[] courses {  get; set; }
		public Nama nama {  get; set; }
		public string gender { get; set; }
		public int age { get; set; }
		public Address address { get; set; }
	}

	public class Nama()
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
	}

	public class Address()
	{
		public string streetAdd { get; set; }
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
		string json = File.ReadAllText("jurnal7_1_103022300010.json");
		Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(json);
		Console.WriteLine($"Nama {mahasiswa.nama.firstName} {mahasiswa.nama.lastName}" +
			$"jenis kelamin {mahasiswa.gender}" +
			$"berusia {mahasiswa.age}" +
			$"alamat {mahasiswa.address}");

		for (int i = 0; i < mahasiswa.courses.Length; i++)
		{
			Console.WriteLine($"daftar matkul: {mahasiswa.courses[i].code}");
            Console.WriteLine($"daftar matkul: {mahasiswa.courses[i].name}");
        }

	}
}
