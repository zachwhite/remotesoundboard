﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Soundboard.Service.Migrations;


namespace Soundboard.Service.Models
{
	public class SoundboardServiceContext : DbContext
	{
		#region Constructors
		public SoundboardServiceContext()
			: base("SoundboardConnectionString")
		{
			Database.SetInitializer(new SoundboardDbConfiguration());
		}
		#endregion


		#region Properties
		public DbSet<Channel> Channels { get; set; }
		public DbSet<Sounds.SoundCategory> SoundCategories { get; set; }
		public DbSet<Sounds.SoundFile> SoundFiles { get; set; }
		public DbSet<Sounds.SoundRecord> SoundRecords { get; set; }
		#endregion
	}
}