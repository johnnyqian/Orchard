using Orchard;

namespace Futures.Modules.Packaging.Services {
    public interface IPackageManager : IDependency {
        PackageData Harvest(string extensionName);
        PackageData Download(string feedItemId);

        void Push(PackageData packageData, string feedUrl);
        void Install(PackageData packageData);
    }
}