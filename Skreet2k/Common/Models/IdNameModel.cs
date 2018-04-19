﻿namespace Common.Models
{
	public class IdNameModel
	{
		public IdNameModel()
		{
		}

		public IdNameModel(int id, string name)
		{
			Id = id;
			Name = name;
		}

		public int Id { get; set; }
		public string Name { get; set; }
	}
}