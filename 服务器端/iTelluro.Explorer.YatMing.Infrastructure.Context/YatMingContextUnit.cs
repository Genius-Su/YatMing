using iTelluro.Explorer.Domain.CodeFirst.Seedwork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Infrastructure.Context.Extention;
using System.Data.Entity.Infrastructure;
using iTelluro.Explorer.Infrastruct.CodeFirst.Seedwork;
using System.Data.SqlClient;

namespace iTelluro.Explorer.YatMing.Infrastructure.Context
{

    public partial class YatMingContext : IQueryableUnitOfWork
    {

        /// <summary>
        /// ��ȡ ��ǰ��Ԫ�����Ƿ��ѱ��ύ
        /// </summary>
        public bool IsCommitted { get; private set; }

        #region IQueryableUnitOfWork ��Ա ��ǰ

        public DbSet<TEntity> CreateSet<TEntity>()
            where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public void Attach<TEntity>(TEntity item)
            where TEntity : class
        {
            //attach and set as unchanged
            base.Entry<TEntity>(item).State = System.Data.EntityState.Unchanged;
        }

        public void SetModified<TEntity>(TEntity item)
            where TEntity : class
        {
            //this operation also attach item in object state manager
            base.Entry<TEntity>(item).State = System.Data.EntityState.Modified;
        }
        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current)
            where TEntity : class
        {
            //if it is not attached, attach original and set current values
            base.Entry<TEntity>(original).CurrentValues.SetValues(current);
        }
        #endregion

        #region IQueryableUnitOfWork ��Ա

        /// <summary>
        /// �ύ��ǰ�����Ľ��
        /// </summary>
        /// <param name="validateOnSaveEnabled">����ʱ�Ƿ��Զ���֤����ʵ��</param>
        /// <returns></returns>
        public int Commit(bool validateOnSaveEnabled = true)
        {
            if (IsCommitted)
            {
                return 0;
            }
            try
            {
                int result = this.SaveChanges(validateOnSaveEnabled);
                IsCommitted = true;
                return result;
            }
            catch (DbUpdateException e)
            {
                if (e.InnerException != null && e.InnerException.InnerException is SqlException)
                {
                    SqlException sqlEx = e.InnerException.InnerException as SqlException;
                    throw new Exception("�ύ���ݸ���ʱ�����쳣��", sqlEx);
                }
                throw;
            }
        }

        /// <summary>
        /// �ѵ�ǰ�����ع���δ�ύ״̬
        /// </summary>
        public void Rollback()
        {
            IsCommitted = false;
        }

        /// <summary>
        /// �ͷ���Դ
        /// </summary>
        public void Dispose()
        {
            if (!IsCommitted)
            {
                Commit();
            }
            this.Dispose();
        }

        /// <summary>
        /// ִ��Sql���(��ѯ)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlQuery">Sql���</param>
        /// <param name="parameters">����</param>
        /// <returns>���ز�ѯ�Ľ��</returns>
        public IQueryable<T> ExecuteQuery<T>(string sqlQuery, params object[] parameters)
        {
            return base.Database.SqlQuery<T>(sqlQuery, parameters).AsQueryable();
        }

        /// <summary>
        /// ִ��Sql���(�飬ɾ����)
        /// </summary>
        /// <param name="sqlCommand">Sql���</param>
        /// <param name="parameters">����</param>
        /// <returns>Ӱ�������</returns>
        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return base.Database.ExecuteSqlCommand(sqlCommand, parameters);
        }

        /// <summary>
        /// ���ʵ��
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void AddEntity<TEntity>(TEntity entity) where TEntity : Entity
        {
            EntityState state = this.Entry(entity).State;
            if (state == EntityState.Detached)
            {
                this.Entry(entity).State = EntityState.Added;
            }
            IsCommitted = false;
        }

        /// <summary>
        /// �������ʵ��
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entities"></param>
        public void AddEntities<TEntity>(IEnumerable<TEntity> entities) where TEntity : Entity
        {
            try
            {
                this.Configuration.AutoDetectChangesEnabled = false;
                foreach (TEntity entity in entities)
                {
                    AddEntity(entity);
                }
            }
            finally
            {
                this.Configuration.AutoDetectChangesEnabled = true;
            }
        }

        /// <summary>
        /// ɾ��ʵ��
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void DeleteEntity<TEntity>(TEntity entity) where TEntity : Entity
        {
            this.Entry(entity).State = EntityState.Deleted;
        }

        /// <summary>
        /// ����ɾ��ʵ��
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entities"></param>
        public void DeleteEntities<TEntity>(IEnumerable<TEntity> entities) where TEntity : Entity
        {
            try
            {
                this.Configuration.AutoDetectChangesEnabled = false;
                foreach (TEntity entity in entities)
                {
                    DeleteEntity(entity);
                }
            }
            finally
            {
                this.Configuration.AutoDetectChangesEnabled = true;
            }
        }

        /// <summary>
        /// ����ʵ��
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        public void UpdateEntity<TEntity>(TEntity entity) where TEntity : Entity
        {
            this.Update<TEntity>(entity);
            IsCommitted = false;
        }

        /// <summary>
        /// ��������ʵ��
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entities"></param>
        public void UpdateEntities<TEntity>(IEnumerable<TEntity> entities) where TEntity : Entity
        {
            this.Update<TEntity>(entities.ToArray());
            IsCommitted = false;
        }

        #endregion
    }
}
