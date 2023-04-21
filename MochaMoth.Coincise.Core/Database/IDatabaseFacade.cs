﻿using Microsoft.Extensions.Configuration;

namespace MochaMoth.Coincise.Core.Database
{
	public interface IDatabaseFacade
	{
		void InitializeDatabase(IConfigurationSection configuration);
	}
}
