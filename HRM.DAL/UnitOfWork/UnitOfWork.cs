using HRM.DAL.DbContext;
using HRM.DAL.EF;
using System;

namespace HRM.DAL
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly HRMContext _dbContext;

		public UnitOfWork(HRMContext dbcontext)
		{
			_dbContext = dbcontext;
		}
		public HRMContext Context
		{
			get { return _dbContext; }
		}
		public void SaveChanges()
		{
			_dbContext.SaveChanges();
		}

		private bool disposedValue = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					_dbContext.Dispose();
				}
				disposedValue = true;
			}
		}
		public void Dispose()
		{

			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
