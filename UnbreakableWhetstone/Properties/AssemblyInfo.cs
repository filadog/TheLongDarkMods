using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MelonLoader;
using UnbreakableWhetstone;
using BuildInfo = UnbreakableWhetstone.BuildInfo;

[assembly: AssemblyTitle(BuildInfo.name)]
[assembly: AssemblyDescription(BuildInfo.description)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct(BuildInfo.name)]
[assembly: AssemblyCopyright("filadog @ 2021")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("0e6700b8-2102-4d52-9234-9c5b79d12661")]
[assembly: AssemblyVersion(BuildInfo.version)]
[assembly: AssemblyFileVersion(BuildInfo.version)]
[assembly: MelonInfo(typeof(Implementation), BuildInfo.name, BuildInfo.version, BuildInfo.author)]
[assembly: MelonGame("Hinterland", "TheLongDark")]
