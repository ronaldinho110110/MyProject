using HRM.DAL.DbContext;
using HRM.DAL.EF;
using System;

namespace HRM.DAL
{
	public interface IUnitOfWork : IDisposable
	{
		HRMContext Context { get; }
		void SaveChanges();
	}
}
