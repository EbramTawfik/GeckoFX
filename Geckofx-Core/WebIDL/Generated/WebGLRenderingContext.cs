namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebGLRenderingContext : WebIDLBase
    {
        
        public WebGLRenderingContext(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public WebIDLUnion<nsIDOMHTMLCanvasElement,nsISupports> Canvas
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsIDOMHTMLCanvasElement,nsISupports>>("canvas");
            }
        }
        
        public Int32 DrawingBufferWidth
        {
            get
            {
                return this.GetProperty<Int32>("drawingBufferWidth");
            }
        }
        
        public Int32 DrawingBufferHeight
        {
            get
            {
                return this.GetProperty<Int32>("drawingBufferHeight");
            }
        }
        
        public object GetContextAttributes()
        {
            return this.CallMethod<object>("getContextAttributes");
        }
        
        public bool IsContextLost()
        {
            return this.CallMethod<bool>("isContextLost");
        }
        
        public nsAString[] GetSupportedExtensions()
        {
            return this.CallMethod<nsAString[]>("getSupportedExtensions");
        }
        
        public object GetExtension(nsAString name)
        {
            return this.CallMethod<object>("getExtension", name);
        }
        
        public void ActiveTexture(UInt32 texture)
        {
            this.CallVoidMethod("activeTexture", texture);
        }
        
        public void AttachShader(nsISupports program, nsISupports shader)
        {
            this.CallVoidMethod("attachShader", program, shader);
        }
        
        public void BindAttribLocation(nsISupports program, UInt32 index, nsAString name)
        {
            this.CallVoidMethod("bindAttribLocation", program, index, name);
        }
        
        public void BindBuffer(UInt32 target, nsISupports buffer)
        {
            this.CallVoidMethod("bindBuffer", target, buffer);
        }
        
        public void BindFramebuffer(UInt32 target, nsISupports framebuffer)
        {
            this.CallVoidMethod("bindFramebuffer", target, framebuffer);
        }
        
        public void BindRenderbuffer(UInt32 target, nsISupports renderbuffer)
        {
            this.CallVoidMethod("bindRenderbuffer", target, renderbuffer);
        }
        
        public void BindTexture(UInt32 target, nsISupports texture)
        {
            this.CallVoidMethod("bindTexture", target, texture);
        }
        
        public void BlendColor(Single red, Single green, Single blue, Single alpha)
        {
            this.CallVoidMethod("blendColor", red, green, blue, alpha);
        }
        
        public void BlendEquation(UInt32 mode)
        {
            this.CallVoidMethod("blendEquation", mode);
        }
        
        public void BlendEquationSeparate(UInt32 modeRGB, UInt32 modeAlpha)
        {
            this.CallVoidMethod("blendEquationSeparate", modeRGB, modeAlpha);
        }
        
        public void BlendFunc(UInt32 sfactor, UInt32 dfactor)
        {
            this.CallVoidMethod("blendFunc", sfactor, dfactor);
        }
        
        public void BlendFuncSeparate(UInt32 srcRGB, UInt32 dstRGB, UInt32 srcAlpha, UInt32 dstAlpha)
        {
            this.CallVoidMethod("blendFuncSeparate", srcRGB, dstRGB, srcAlpha, dstAlpha);
        }
        
        public void BufferData(UInt32 target, Int64 size, UInt32 usage)
        {
            this.CallVoidMethod("bufferData", target, size, usage);
        }
        
        public void BufferData(UInt32 target, IntPtr data, UInt32 usage)
        {
            this.CallVoidMethod("bufferData", target, data, usage);
        }
        
        public void BufferData(UInt32 target, SharedArrayBuffer data, UInt32 usage)
        {
            this.CallVoidMethod("bufferData", target, data, usage);
        }
        
        public void BufferSubData(UInt32 target, Int64 offset, IntPtr data)
        {
            this.CallVoidMethod("bufferSubData", target, offset, data);
        }
        
        public void BufferSubData(UInt32 target, Int64 offset, SharedArrayBuffer data)
        {
            this.CallVoidMethod("bufferSubData", target, offset, data);
        }
        
        public UInt32 CheckFramebufferStatus(UInt32 target)
        {
            return this.CallMethod<UInt32>("checkFramebufferStatus", target);
        }
        
        public void Clear(UInt32 mask)
        {
            this.CallVoidMethod("clear", mask);
        }
        
        public void ClearColor(Single red, Single green, Single blue, Single alpha)
        {
            this.CallVoidMethod("clearColor", red, green, blue, alpha);
        }
        
        public void ClearDepth(Single depth)
        {
            this.CallVoidMethod("clearDepth", depth);
        }
        
        public void ClearStencil(Int32 s)
        {
            this.CallVoidMethod("clearStencil", s);
        }
        
        public void ColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha)
        {
            this.CallVoidMethod("colorMask", red, green, blue, alpha);
        }
        
        public void CompileShader(nsISupports shader)
        {
            this.CallVoidMethod("compileShader", shader);
        }
        
        public void CompressedTexImage2D(UInt32 target, Int32 level, UInt32 internalformat, Int32 width, Int32 height, Int32 border, IntPtr data)
        {
            this.CallVoidMethod("compressedTexImage2D", target, level, internalformat, width, height, border, data);
        }
        
        public void CompressedTexSubImage2D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, UInt32 format, IntPtr data)
        {
            this.CallVoidMethod("compressedTexSubImage2D", target, level, xoffset, yoffset, width, height, format, data);
        }
        
        public void CopyTexImage2D(UInt32 target, Int32 level, UInt32 internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
        {
            this.CallVoidMethod("copyTexImage2D", target, level, internalformat, x, y, width, height, border);
        }
        
        public void CopyTexSubImage2D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            this.CallVoidMethod("copyTexSubImage2D", target, level, xoffset, yoffset, x, y, width, height);
        }
        
        public nsISupports CreateBuffer()
        {
            return this.CallMethod<nsISupports>("createBuffer");
        }
        
        public nsISupports CreateFramebuffer()
        {
            return this.CallMethod<nsISupports>("createFramebuffer");
        }
        
        public nsISupports CreateProgram()
        {
            return this.CallMethod<nsISupports>("createProgram");
        }
        
        public nsISupports CreateRenderbuffer()
        {
            return this.CallMethod<nsISupports>("createRenderbuffer");
        }
        
        public nsISupports CreateShader(UInt32 type)
        {
            return this.CallMethod<nsISupports>("createShader", type);
        }
        
        public nsISupports CreateTexture()
        {
            return this.CallMethod<nsISupports>("createTexture");
        }
        
        public void CullFace(UInt32 mode)
        {
            this.CallVoidMethod("cullFace", mode);
        }
        
        public void DeleteBuffer(nsISupports buffer)
        {
            this.CallVoidMethod("deleteBuffer", buffer);
        }
        
        public void DeleteFramebuffer(nsISupports framebuffer)
        {
            this.CallVoidMethod("deleteFramebuffer", framebuffer);
        }
        
        public void DeleteProgram(nsISupports program)
        {
            this.CallVoidMethod("deleteProgram", program);
        }
        
        public void DeleteRenderbuffer(nsISupports renderbuffer)
        {
            this.CallVoidMethod("deleteRenderbuffer", renderbuffer);
        }
        
        public void DeleteShader(nsISupports shader)
        {
            this.CallVoidMethod("deleteShader", shader);
        }
        
        public void DeleteTexture(nsISupports texture)
        {
            this.CallVoidMethod("deleteTexture", texture);
        }
        
        public void DepthFunc(UInt32 func)
        {
            this.CallVoidMethod("depthFunc", func);
        }
        
        public void DepthMask(Boolean flag)
        {
            this.CallVoidMethod("depthMask", flag);
        }
        
        public void DepthRange(Single zNear, Single zFar)
        {
            this.CallVoidMethod("depthRange", zNear, zFar);
        }
        
        public void DetachShader(nsISupports program, nsISupports shader)
        {
            this.CallVoidMethod("detachShader", program, shader);
        }
        
        public void Disable(UInt32 cap)
        {
            this.CallVoidMethod("disable", cap);
        }
        
        public void DisableVertexAttribArray(UInt32 index)
        {
            this.CallVoidMethod("disableVertexAttribArray", index);
        }
        
        public void DrawArrays(UInt32 mode, Int32 first, Int32 count)
        {
            this.CallVoidMethod("drawArrays", mode, first, count);
        }
        
        public void DrawElements(UInt32 mode, Int32 count, UInt32 type, Int64 offset)
        {
            this.CallVoidMethod("drawElements", mode, count, type, offset);
        }
        
        public void Enable(UInt32 cap)
        {
            this.CallVoidMethod("enable", cap);
        }
        
        public void EnableVertexAttribArray(UInt32 index)
        {
            this.CallVoidMethod("enableVertexAttribArray", index);
        }
        
        public void Finish()
        {
            this.CallVoidMethod("finish");
        }
        
        public void Flush()
        {
            this.CallVoidMethod("flush");
        }
        
        public void FramebufferRenderbuffer(UInt32 target, UInt32 attachment, UInt32 renderbuffertarget, nsISupports renderbuffer)
        {
            this.CallVoidMethod("framebufferRenderbuffer", target, attachment, renderbuffertarget, renderbuffer);
        }
        
        public void FramebufferTexture2D(UInt32 target, UInt32 attachment, UInt32 textarget, nsISupports texture, Int32 level)
        {
            this.CallVoidMethod("framebufferTexture2D", target, attachment, textarget, texture, level);
        }
        
        public void FrontFace(UInt32 mode)
        {
            this.CallVoidMethod("frontFace", mode);
        }
        
        public void GenerateMipmap(UInt32 target)
        {
            this.CallVoidMethod("generateMipmap", target);
        }
        
        public nsISupports GetActiveAttrib(nsISupports program, UInt32 index)
        {
            return this.CallMethod<nsISupports>("getActiveAttrib", program, index);
        }
        
        public nsISupports GetActiveUniform(nsISupports program, UInt32 index)
        {
            return this.CallMethod<nsISupports>("getActiveUniform", program, index);
        }
        
        public nsISupports[] GetAttachedShaders(nsISupports program)
        {
            return this.CallMethod<nsISupports[]>("getAttachedShaders", program);
        }
        
        public Int32 GetAttribLocation(nsISupports program, nsAString name)
        {
            return this.CallMethod<Int32>("getAttribLocation", program, name);
        }
        
        public object GetBufferParameter(UInt32 target, UInt32 pname)
        {
            return this.CallMethod<object>("getBufferParameter", target, pname);
        }
        
        public object GetParameter(UInt32 pname)
        {
            return this.CallMethod<object>("getParameter", pname);
        }
        
        public UInt32 GetError()
        {
            return this.CallMethod<UInt32>("getError");
        }
        
        public object GetFramebufferAttachmentParameter(UInt32 target, UInt32 attachment, UInt32 pname)
        {
            return this.CallMethod<object>("getFramebufferAttachmentParameter", target, attachment, pname);
        }
        
        public object GetProgramParameter(nsISupports program, UInt32 pname)
        {
            return this.CallMethod<object>("getProgramParameter", program, pname);
        }
        
        public nsAString GetProgramInfoLog(nsISupports program)
        {
            return this.CallMethod<nsAString>("getProgramInfoLog", program);
        }
        
        public object GetRenderbufferParameter(UInt32 target, UInt32 pname)
        {
            return this.CallMethod<object>("getRenderbufferParameter", target, pname);
        }
        
        public object GetShaderParameter(nsISupports shader, UInt32 pname)
        {
            return this.CallMethod<object>("getShaderParameter", shader, pname);
        }
        
        public nsISupports GetShaderPrecisionFormat(UInt32 shadertype, UInt32 precisiontype)
        {
            return this.CallMethod<nsISupports>("getShaderPrecisionFormat", shadertype, precisiontype);
        }
        
        public nsAString GetShaderInfoLog(nsISupports shader)
        {
            return this.CallMethod<nsAString>("getShaderInfoLog", shader);
        }
        
        public nsAString GetShaderSource(nsISupports shader)
        {
            return this.CallMethod<nsAString>("getShaderSource", shader);
        }
        
        public object GetTexParameter(UInt32 target, UInt32 pname)
        {
            return this.CallMethod<object>("getTexParameter", target, pname);
        }
        
        public object GetUniform(nsISupports program, nsISupports location)
        {
            return this.CallMethod<object>("getUniform", program, location);
        }
        
        public nsISupports GetUniformLocation(nsISupports program, nsAString name)
        {
            return this.CallMethod<nsISupports>("getUniformLocation", program, name);
        }
        
        public object GetVertexAttrib(UInt32 index, UInt32 pname)
        {
            return this.CallMethod<object>("getVertexAttrib", index, pname);
        }
        
        public Int64 GetVertexAttribOffset(UInt32 index, UInt32 pname)
        {
            return this.CallMethod<Int64>("getVertexAttribOffset", index, pname);
        }
        
        public void Hint(UInt32 target, UInt32 mode)
        {
            this.CallVoidMethod("hint", target, mode);
        }
        
        public Boolean IsBuffer(nsISupports buffer)
        {
            return this.CallMethod<Boolean>("isBuffer", buffer);
        }
        
        public Boolean IsEnabled(UInt32 cap)
        {
            return this.CallMethod<Boolean>("isEnabled", cap);
        }
        
        public Boolean IsFramebuffer(nsISupports framebuffer)
        {
            return this.CallMethod<Boolean>("isFramebuffer", framebuffer);
        }
        
        public Boolean IsProgram(nsISupports program)
        {
            return this.CallMethod<Boolean>("isProgram", program);
        }
        
        public Boolean IsRenderbuffer(nsISupports renderbuffer)
        {
            return this.CallMethod<Boolean>("isRenderbuffer", renderbuffer);
        }
        
        public Boolean IsShader(nsISupports shader)
        {
            return this.CallMethod<Boolean>("isShader", shader);
        }
        
        public Boolean IsTexture(nsISupports texture)
        {
            return this.CallMethod<Boolean>("isTexture", texture);
        }
        
        public void LineWidth(Single width)
        {
            this.CallVoidMethod("lineWidth", width);
        }
        
        public void LinkProgram(nsISupports program)
        {
            this.CallVoidMethod("linkProgram", program);
        }
        
        public void PixelStorei(UInt32 pname, Int32 param)
        {
            this.CallVoidMethod("pixelStorei", pname, param);
        }
        
        public void PolygonOffset(Single factor, Single units)
        {
            this.CallVoidMethod("polygonOffset", factor, units);
        }
        
        public void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, UInt32 format, UInt32 type, IntPtr pixels)
        {
            this.CallVoidMethod("readPixels", x, y, width, height, format, type, pixels);
        }
        
        public void RenderbufferStorage(UInt32 target, UInt32 internalformat, Int32 width, Int32 height)
        {
            this.CallVoidMethod("renderbufferStorage", target, internalformat, width, height);
        }
        
        public void SampleCoverage(Single value, Boolean invert)
        {
            this.CallVoidMethod("sampleCoverage", value, invert);
        }
        
        public void Scissor(Int32 x, Int32 y, Int32 width, Int32 height)
        {
            this.CallVoidMethod("scissor", x, y, width, height);
        }
        
        public void ShaderSource(nsISupports shader, nsAString source)
        {
            this.CallVoidMethod("shaderSource", shader, source);
        }
        
        public void StencilFunc(UInt32 func, Int32 @ref, UInt32 mask)
        {
            this.CallVoidMethod("stencilFunc", func, @ref, mask);
        }
        
        public void StencilFuncSeparate(UInt32 face, UInt32 func, Int32 @ref, UInt32 mask)
        {
            this.CallVoidMethod("stencilFuncSeparate", face, func, @ref, mask);
        }
        
        public void StencilMask(UInt32 mask)
        {
            this.CallVoidMethod("stencilMask", mask);
        }
        
        public void StencilMaskSeparate(UInt32 face, UInt32 mask)
        {
            this.CallVoidMethod("stencilMaskSeparate", face, mask);
        }
        
        public void StencilOp(UInt32 fail, UInt32 zfail, UInt32 zpass)
        {
            this.CallVoidMethod("stencilOp", fail, zfail, zpass);
        }
        
        public void StencilOpSeparate(UInt32 face, UInt32 fail, UInt32 zfail, UInt32 zpass)
        {
            this.CallVoidMethod("stencilOpSeparate", face, fail, zfail, zpass);
        }
        
        public void TexImage2D(UInt32 target, Int32 level, UInt32 internalformat, Int32 width, Int32 height, Int32 border, UInt32 format, UInt32 type, IntPtr pixels)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, width, height, border, format, type, pixels);
        }
        
        public void TexImage2D(UInt32 target, Int32 level, UInt32 internalformat, UInt32 format, UInt32 type, nsISupports pixels)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, format, type, pixels);
        }
        
        public void TexImage2D(UInt32 target, Int32 level, UInt32 internalformat, UInt32 format, UInt32 type, nsIDOMHTMLImageElement image)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, format, type, image);
        }
        
        public void TexImage2D(UInt32 target, Int32 level, UInt32 internalformat, UInt32 format, UInt32 type, nsIDOMHTMLCanvasElement canvas)
        {
            this.CallVoidMethod("texImage2D", target, level, internalformat, format, type, canvas);
        }
        
        public void TexParameterf(UInt32 target, UInt32 pname, Single param)
        {
            this.CallVoidMethod("texParameterf", target, pname, param);
        }
        
        public void TexParameteri(UInt32 target, UInt32 pname, Int32 param)
        {
            this.CallVoidMethod("texParameteri", target, pname, param);
        }
        
        public void TexSubImage2D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, UInt32 format, UInt32 type, IntPtr pixels)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, width, height, format, type, pixels);
        }
        
        public void TexSubImage2D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, UInt32 format, UInt32 type, nsISupports pixels)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, format, type, pixels);
        }
        
        public void TexSubImage2D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, UInt32 format, UInt32 type, nsIDOMHTMLImageElement image)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, format, type, image);
        }
        
        public void TexSubImage2D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, UInt32 format, UInt32 type, nsIDOMHTMLCanvasElement canvas)
        {
            this.CallVoidMethod("texSubImage2D", target, level, xoffset, yoffset, format, type, canvas);
        }
        
        public void Uniform1f(nsISupports location, Single x)
        {
            this.CallVoidMethod("uniform1f", location, x);
        }
        
        public void Uniform1fv(nsISupports location, IntPtr v)
        {
            this.CallVoidMethod("uniform1fv", location, v);
        }
        
        public void Uniform1fv(nsISupports location, Single[] v)
        {
            this.CallVoidMethod("uniform1fv", location, v);
        }
        
        public void Uniform1i(nsISupports location, Int32 x)
        {
            this.CallVoidMethod("uniform1i", location, x);
        }
        
        public void Uniform1iv(nsISupports location, IntPtr v)
        {
            this.CallVoidMethod("uniform1iv", location, v);
        }
        
        public void Uniform1iv(nsISupports location, int[] v)
        {
            this.CallVoidMethod("uniform1iv", location, v);
        }
        
        public void Uniform2f(nsISupports location, Single x, Single y)
        {
            this.CallVoidMethod("uniform2f", location, x, y);
        }
        
        public void Uniform2fv(nsISupports location, IntPtr v)
        {
            this.CallVoidMethod("uniform2fv", location, v);
        }
        
        public void Uniform2fv(nsISupports location, Single[] v)
        {
            this.CallVoidMethod("uniform2fv", location, v);
        }
        
        public void Uniform2i(nsISupports location, Int32 x, Int32 y)
        {
            this.CallVoidMethod("uniform2i", location, x, y);
        }
        
        public void Uniform2iv(nsISupports location, IntPtr v)
        {
            this.CallVoidMethod("uniform2iv", location, v);
        }
        
        public void Uniform2iv(nsISupports location, int[] v)
        {
            this.CallVoidMethod("uniform2iv", location, v);
        }
        
        public void Uniform3f(nsISupports location, Single x, Single y, Single z)
        {
            this.CallVoidMethod("uniform3f", location, x, y, z);
        }
        
        public void Uniform3fv(nsISupports location, IntPtr v)
        {
            this.CallVoidMethod("uniform3fv", location, v);
        }
        
        public void Uniform3fv(nsISupports location, Single[] v)
        {
            this.CallVoidMethod("uniform3fv", location, v);
        }
        
        public void Uniform3i(nsISupports location, Int32 x, Int32 y, Int32 z)
        {
            this.CallVoidMethod("uniform3i", location, x, y, z);
        }
        
        public void Uniform3iv(nsISupports location, IntPtr v)
        {
            this.CallVoidMethod("uniform3iv", location, v);
        }
        
        public void Uniform3iv(nsISupports location, int[] v)
        {
            this.CallVoidMethod("uniform3iv", location, v);
        }
        
        public void Uniform4f(nsISupports location, Single x, Single y, Single z, Single w)
        {
            this.CallVoidMethod("uniform4f", location, x, y, z, w);
        }
        
        public void Uniform4fv(nsISupports location, IntPtr v)
        {
            this.CallVoidMethod("uniform4fv", location, v);
        }
        
        public void Uniform4fv(nsISupports location, Single[] v)
        {
            this.CallVoidMethod("uniform4fv", location, v);
        }
        
        public void Uniform4i(nsISupports location, Int32 x, Int32 y, Int32 z, Int32 w)
        {
            this.CallVoidMethod("uniform4i", location, x, y, z, w);
        }
        
        public void Uniform4iv(nsISupports location, IntPtr v)
        {
            this.CallVoidMethod("uniform4iv", location, v);
        }
        
        public void Uniform4iv(nsISupports location, int[] v)
        {
            this.CallVoidMethod("uniform4iv", location, v);
        }
        
        public void UniformMatrix2fv(nsISupports location, Boolean transpose, IntPtr value)
        {
            this.CallVoidMethod("uniformMatrix2fv", location, transpose, value);
        }
        
        public void UniformMatrix2fv(nsISupports location, Boolean transpose, Single[] value)
        {
            this.CallVoidMethod("uniformMatrix2fv", location, transpose, value);
        }
        
        public void UniformMatrix3fv(nsISupports location, Boolean transpose, IntPtr value)
        {
            this.CallVoidMethod("uniformMatrix3fv", location, transpose, value);
        }
        
        public void UniformMatrix3fv(nsISupports location, Boolean transpose, Single[] value)
        {
            this.CallVoidMethod("uniformMatrix3fv", location, transpose, value);
        }
        
        public void UniformMatrix4fv(nsISupports location, Boolean transpose, IntPtr value)
        {
            this.CallVoidMethod("uniformMatrix4fv", location, transpose, value);
        }
        
        public void UniformMatrix4fv(nsISupports location, Boolean transpose, Single[] value)
        {
            this.CallVoidMethod("uniformMatrix4fv", location, transpose, value);
        }
        
        public void UseProgram(nsISupports program)
        {
            this.CallVoidMethod("useProgram", program);
        }
        
        public void ValidateProgram(nsISupports program)
        {
            this.CallVoidMethod("validateProgram", program);
        }
        
        public void VertexAttrib1f(UInt32 indx, Single x)
        {
            this.CallVoidMethod("vertexAttrib1f", indx, x);
        }
        
        public void VertexAttrib1fv(UInt32 indx, IntPtr values)
        {
            this.CallVoidMethod("vertexAttrib1fv", indx, values);
        }
        
        public void VertexAttrib1fv(UInt32 indx, Single[] values)
        {
            this.CallVoidMethod("vertexAttrib1fv", indx, values);
        }
        
        public void VertexAttrib2f(UInt32 indx, Single x, Single y)
        {
            this.CallVoidMethod("vertexAttrib2f", indx, x, y);
        }
        
        public void VertexAttrib2fv(UInt32 indx, IntPtr values)
        {
            this.CallVoidMethod("vertexAttrib2fv", indx, values);
        }
        
        public void VertexAttrib2fv(UInt32 indx, Single[] values)
        {
            this.CallVoidMethod("vertexAttrib2fv", indx, values);
        }
        
        public void VertexAttrib3f(UInt32 indx, Single x, Single y, Single z)
        {
            this.CallVoidMethod("vertexAttrib3f", indx, x, y, z);
        }
        
        public void VertexAttrib3fv(UInt32 indx, IntPtr values)
        {
            this.CallVoidMethod("vertexAttrib3fv", indx, values);
        }
        
        public void VertexAttrib3fv(UInt32 indx, Single[] values)
        {
            this.CallVoidMethod("vertexAttrib3fv", indx, values);
        }
        
        public void VertexAttrib4f(UInt32 indx, Single x, Single y, Single z, Single w)
        {
            this.CallVoidMethod("vertexAttrib4f", indx, x, y, z, w);
        }
        
        public void VertexAttrib4fv(UInt32 indx, IntPtr values)
        {
            this.CallVoidMethod("vertexAttrib4fv", indx, values);
        }
        
        public void VertexAttrib4fv(UInt32 indx, Single[] values)
        {
            this.CallVoidMethod("vertexAttrib4fv", indx, values);
        }
        
        public void VertexAttribPointer(UInt32 indx, Int32 size, UInt32 type, Boolean normalized, Int32 stride, Int64 offset)
        {
            this.CallVoidMethod("vertexAttribPointer", indx, size, type, normalized, stride, offset);
        }
        
        public void Viewport(Int32 x, Int32 y, Int32 width, Int32 height)
        {
            this.CallVoidMethod("viewport", x, y, width, height);
        }
        
        public void Commit()
        {
            this.CallVoidMethod("commit");
        }
    }
}
