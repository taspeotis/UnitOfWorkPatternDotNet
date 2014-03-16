using System;
using System.Threading;
using System.Threading.Tasks;

namespace UnitOfWorkPatternDotNet
{
    /// <summary>Represents a unit of work that can be committed asynchronously.</summary>
    /// <remarks>Call <see cref="IDisposable.Dispose">Dispose</see> to abandon the unit of work.</remarks>
    public interface IAsyncUnitOfWork : IDisposable
    {
        /// <summary>
        ///     Asynchronously commits all changes made in this unit of work.
        /// </summary>
        /// <returns>
        ///     A task that represents the asynchronous commit operation. The task result contains the
        ///     number of objects modified, or <see langword="null" /> if that information is not available.
        /// </returns>
        Task<int?> CommitAsync();

        /// <summary>
        ///     Asynchronously commits all changes made in this unit of work.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that should be used to cancel the work.
        /// </param>
        /// <returns>
        ///     A task that represents the asynchronous commit operation. The task result contains the
        ///     number of objects modified, or <see langword="null" /> if that information is not available.
        /// </returns>
        Task<int?> CommitAsync(CancellationToken cancellationToken);
    }
}