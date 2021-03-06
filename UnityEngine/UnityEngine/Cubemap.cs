﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.Cubemap
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
  /// <summary>
  ///   <para>Class for handling cube maps, Use this to create or modify existing.</para>
  /// </summary>
  public sealed class Cubemap : Texture
  {
    /// <summary>
    ///   <para>How many mipmap levels are in this texture (Read Only).</para>
    /// </summary>
    public int mipmapCount { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>The format of the pixel data in the texture (Read Only).</para>
    /// </summary>
    public TextureFormat format { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    /// <summary>
    ///   <para>Create a new empty cubemap texture.</para>
    /// </summary>
    /// <param name="size">Width/height of a cube face in pixels.</param>
    /// <param name="format">Pixel data format to be used for the Cubemap.</param>
    /// <param name="mipmap">Should mipmaps be created?</param>
    public Cubemap(int size, TextureFormat format, bool mipmap)
    {
      Cubemap.Internal_Create(this, size, format, mipmap);
    }

    /// <summary>
    ///   <para>Sets pixel color at coordinates (face, x, y).</para>
    /// </summary>
    /// <param name="face"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="color"></param>
    public void SetPixel(CubemapFace face, int x, int y, Color color)
    {
      Cubemap.INTERNAL_CALL_SetPixel(this, face, x, y, ref color);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_SetPixel(Cubemap self, CubemapFace face, int x, int y, ref Color color);

    /// <summary>
    ///   <para>Returns pixel color at coordinates (face, x, y).</para>
    /// </summary>
    /// <param name="face"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public Color GetPixel(CubemapFace face, int x, int y)
    {
      Color color;
      Cubemap.INTERNAL_CALL_GetPixel(this, face, x, y, out color);
      return color;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_GetPixel(Cubemap self, CubemapFace face, int x, int y, out Color value);

    /// <summary>
    ///   <para>Returns pixel colors of a cubemap face.</para>
    /// </summary>
    /// <param name="face">The face from which pixel data is taken.</param>
    /// <param name="miplevel">Mipmap level for the chosen face.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public Color[] GetPixels(CubemapFace face, [DefaultValue("0")] int miplevel);

    [ExcludeFromDocs]
    public Color[] GetPixels(CubemapFace face)
    {
      int miplevel = 0;
      return this.GetPixels(face, miplevel);
    }

    /// <summary>
    ///   <para>Sets pixel colors of a cubemap face.</para>
    /// </summary>
    /// <param name="colors">Pixel data for the Cubemap face.</param>
    /// <param name="face">The face to which the new data should be applied.</param>
    /// <param name="miplevel">The mipmap level for the face.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void SetPixels(Color[] colors, CubemapFace face, [DefaultValue("0")] int miplevel);

    [ExcludeFromDocs]
    public void SetPixels(Color[] colors, CubemapFace face)
    {
      int miplevel = 0;
      this.SetPixels(colors, face, miplevel);
    }

    /// <summary>
    ///   <para>Actually apply all previous SetPixel and SetPixels changes.</para>
    /// </summary>
    /// <param name="updateMipmaps">Should all mipmap levels be updated?</param>
    /// <param name="makeNoLongerReadable">Should the Cubemap texture data be readable/modifiable after changes are applied?</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable);

    [ExcludeFromDocs]
    public void Apply(bool updateMipmaps)
    {
      bool makeNoLongerReadable = false;
      this.Apply(updateMipmaps, makeNoLongerReadable);
    }

    [ExcludeFromDocs]
    public void Apply()
    {
      this.Apply(true, false);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_Create([Writable] Cubemap mono, int size, TextureFormat format, bool mipmap);

    /// <summary>
    ///   <para>Performs smoothing of near edge regions.</para>
    /// </summary>
    /// <param name="smoothRegionWidthInPixels">Pixel distance at edges over which to apply smoothing.</param>
    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    public void SmoothEdges([DefaultValue("1")] int smoothRegionWidthInPixels);

    [ExcludeFromDocs]
    public void SmoothEdges()
    {
      this.SmoothEdges(1);
    }
  }
}
