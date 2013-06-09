using System;

namespace UnitOfWorkPatternDotNet
{
    /// <summary>
    ///     Represents a unit of work.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        ///     Commits the unit of work.
        /// </summary>
        /// <remarks>
        ///     Call <see cref="IDisposable.Dispose">Dispose</see> to abandon the unit of work.
        /// </remarks>
        void Commit();
    }
}
