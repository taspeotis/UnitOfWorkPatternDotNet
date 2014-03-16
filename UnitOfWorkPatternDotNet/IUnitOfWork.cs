using System;

namespace UnitOfWorkPatternDotNet
{
    /// <summary>Represents a unit of work that can be committed synchronously.</summary>
    /// <remarks>Call <see cref="IDisposable.Dispose">Dispose</see> to abandon the unit of work.</remarks>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        ///     Commits all changes made in this unit of work.
        /// </summary>
        /// <returns>
        ///     The number of objects modified, or <see langword="null" /> if that information is not available.
        /// </returns>
        int? Commit();
    }
}