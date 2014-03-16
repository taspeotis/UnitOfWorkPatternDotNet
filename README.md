## UnitOfWorkPatternDotNet

Two (extremely) lightweight UoW interfaces.

### License

*UnitOfWorkPatternDotNet* is licensed under the [*Microsoft Public License (MS-PL)*](http://www.microsoft.com/en-us/openness/licenses.aspx).

### Getting Started

[*UnitOfWorkPatternDotNet* is available on NuGet](https://www.nuget.org/packages/UnitOfWorkPatternDotNet).

If you're using Entity Framework consider using [*UnitOfWorkPatternDotNet.EntityFramework*](https://github.com/taspeotis/UnitOfWorkPatternDotNet.EntityFramework) and/or [*RepositoryPatternDotNet.EntityFramework*](https://github.com/taspeotis/RepositoryPatternDotNet.EntityFramework) to get your data access layer started faster.

### Usage

*UnitOfWorkPatternDotNet* contains two interfaces that you can implement. The methods exposed on the interfaces are complementary, but either interface can be used independently of the other.

The `IUnitOfWork` interface contains a `Commit` method for committing a unit of work synchronously.

The `IAsyncUnitOfWork` interface contains a `CommitAsync` method for commiting a unit of work asynchronously. An overload of `CommitAsync` takes a `CancellationToken`.

Both interfaces inherit from `IDisposable` so `Dispose` can be used for abandoning the unit of work:

    using (IUnitOfWork unitOfWork = GetUnitOfWork())
    {
        // ... use unitOfWork

        unitOfWork.Commit();
    }

    using (IAsyncUnitOfWork asyncUnitOfWork = GetAsyncUnitOfWork())
    {
        // ... use asyncUnitOfWork

        await asyncUnitOfWork.CommitAsync(cancellationToken);
        // or simply await asyncUnitOfWork.CommitAsync(); 
    }