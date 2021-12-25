using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MelonLoader;
using UnbreakableBedroll;
using BuildInfo = UnbreakableBedroll.BuildInfo;

[assembly: AssemblyTitle(BuildInfo.name)]
[assembly: AssemblyDescription(BuildInfo.description)]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct(BuildInfo.name)]
[assembly: AssemblyCopyright("Made by filadog")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("63f40beb-161b-4715-8504-bc1af0544c82")]
[assembly: AssemblyVersion(BuildInfo.version)]
[assembly: AssemblyFileVersion(BuildInfo.version)]
[assembly: MelonInfo(typeof(Implementation), BuildInfo.name, BuildInfo.version, BuildInfo.author)]
[assembly: MelonGame("Hinterland", "TheLongDark")]
