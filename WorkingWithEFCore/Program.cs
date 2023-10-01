using WorkingWithEntityFrameWorkCore;

Northwind db = new();
WriteLine($"Provider : {db.Database.ProviderName}");