// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;

namespace HexaEngine.Shaderc
{
	/// <summary>
	/// An opaque handle to an object that manages all compiler state.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct ShadercCompiler : IEquatable<ShadercCompiler>
	{
		public ShadercCompiler(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static ShadercCompiler Null => new ShadercCompiler(0);
		public static implicit operator ShadercCompiler(nint handle) => new ShadercCompiler(handle);
		public static bool operator ==(ShadercCompiler left, ShadercCompiler right) => left.Handle == right.Handle;
		public static bool operator !=(ShadercCompiler left, ShadercCompiler right) => left.Handle != right.Handle;
		public static bool operator ==(ShadercCompiler left, nint right) => left.Handle == right;
		public static bool operator !=(ShadercCompiler left, nint right) => left.Handle != right;
		public bool Equals(ShadercCompiler other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ShadercCompiler handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("ShadercCompiler [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// An opaque handle to an object that manages options to a single compilation
	/// result.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct ShadercCompileOptions : IEquatable<ShadercCompileOptions>
	{
		public ShadercCompileOptions(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static ShadercCompileOptions Null => new ShadercCompileOptions(0);
		public static implicit operator ShadercCompileOptions(nint handle) => new ShadercCompileOptions(handle);
		public static bool operator ==(ShadercCompileOptions left, ShadercCompileOptions right) => left.Handle == right.Handle;
		public static bool operator !=(ShadercCompileOptions left, ShadercCompileOptions right) => left.Handle != right.Handle;
		public static bool operator ==(ShadercCompileOptions left, nint right) => left.Handle == right;
		public static bool operator !=(ShadercCompileOptions left, nint right) => left.Handle != right;
		public bool Equals(ShadercCompileOptions other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ShadercCompileOptions handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("ShadercCompileOptions [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// An includer callback type for mapping an #include request to an include
	/// result.  The user_data parameter specifies the client context.  The
	/// requested_source parameter specifies the name of the source being requested.
	/// The type parameter specifies the kind of inclusion request being made.
	/// The requesting_source parameter specifies the name of the source containing
	/// the #include request.  The includer owns the result object and its contents,
	/// and both must remain valid until the release callback is called on the result
	/// object.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct ShadercIncludeResolveFn : IEquatable<ShadercIncludeResolveFn>
	{
		public ShadercIncludeResolveFn(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static ShadercIncludeResolveFn Null => new ShadercIncludeResolveFn(0);
		public static implicit operator ShadercIncludeResolveFn(nint handle) => new ShadercIncludeResolveFn(handle);
		public static bool operator ==(ShadercIncludeResolveFn left, ShadercIncludeResolveFn right) => left.Handle == right.Handle;
		public static bool operator !=(ShadercIncludeResolveFn left, ShadercIncludeResolveFn right) => left.Handle != right.Handle;
		public static bool operator ==(ShadercIncludeResolveFn left, nint right) => left.Handle == right;
		public static bool operator !=(ShadercIncludeResolveFn left, nint right) => left.Handle != right;
		public bool Equals(ShadercIncludeResolveFn other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ShadercIncludeResolveFn handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("ShadercIncludeResolveFn [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// An includer callback type for destroying an include result.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct ShadercIncludeResultReleaseFn : IEquatable<ShadercIncludeResultReleaseFn>
	{
		public ShadercIncludeResultReleaseFn(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static ShadercIncludeResultReleaseFn Null => new ShadercIncludeResultReleaseFn(0);
		public static implicit operator ShadercIncludeResultReleaseFn(nint handle) => new ShadercIncludeResultReleaseFn(handle);
		public static bool operator ==(ShadercIncludeResultReleaseFn left, ShadercIncludeResultReleaseFn right) => left.Handle == right.Handle;
		public static bool operator !=(ShadercIncludeResultReleaseFn left, ShadercIncludeResultReleaseFn right) => left.Handle != right.Handle;
		public static bool operator ==(ShadercIncludeResultReleaseFn left, nint right) => left.Handle == right;
		public static bool operator !=(ShadercIncludeResultReleaseFn left, nint right) => left.Handle != right;
		public bool Equals(ShadercIncludeResultReleaseFn other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ShadercIncludeResultReleaseFn handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("ShadercIncludeResultReleaseFn [0x{0}]", Handle.ToString("X"));
	}

	/// <summary>
	/// An opaque handle to the results of a call to any shaderc_compile_into_*()
	/// function.
	/// </summary>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public readonly partial struct ShadercCompilationResult : IEquatable<ShadercCompilationResult>
	{
		public ShadercCompilationResult(nint handle) { Handle = handle; }
		public nint Handle { get; }
		public bool IsNull => Handle == 0;
		public static ShadercCompilationResult Null => new ShadercCompilationResult(0);
		public static implicit operator ShadercCompilationResult(nint handle) => new ShadercCompilationResult(handle);
		public static bool operator ==(ShadercCompilationResult left, ShadercCompilationResult right) => left.Handle == right.Handle;
		public static bool operator !=(ShadercCompilationResult left, ShadercCompilationResult right) => left.Handle != right.Handle;
		public static bool operator ==(ShadercCompilationResult left, nint right) => left.Handle == right;
		public static bool operator !=(ShadercCompilationResult left, nint right) => left.Handle != right;
		public bool Equals(ShadercCompilationResult other) => Handle == other.Handle;
		/// <inheritdoc/>
		public override bool Equals(object obj) => obj is ShadercCompilationResult handle && Equals(handle);
		/// <inheritdoc/>
		public override int GetHashCode() => Handle.GetHashCode();
		private string DebuggerDisplay => string.Format("ShadercCompilationResult [0x{0}]", Handle.ToString("X"));
	}

}
