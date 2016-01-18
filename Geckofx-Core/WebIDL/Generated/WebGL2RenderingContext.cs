namespace Gecko.WebIDL
{
    using System;
    
    
    public class WebGL2RenderingContext : WebIDLBase
    {
        
        public WebGL2RenderingContext(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void CopyBufferSubData(UInt32 readTarget, UInt32 writeTarget, Int64 readOffset, Int64 writeOffset, Int64 size)
        {
            this.CallVoidMethod("copyBufferSubData", readTarget, writeTarget, readOffset, writeOffset, size);
        }
        
        public void GetBufferSubData(UInt32 target, Int64 offset, IntPtr returnedData)
        {
            this.CallVoidMethod("getBufferSubData", target, offset, returnedData);
        }
        
        public void GetBufferSubData(UInt32 target, Int64 offset, SharedArrayBuffer returnedData)
        {
            this.CallVoidMethod("getBufferSubData", target, offset, returnedData);
        }
        
        public void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, UInt32 filter)
        {
            this.CallVoidMethod("blitFramebuffer", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }
        
        public void FramebufferTextureLayer(UInt32 target, UInt32 attachment, nsISupports texture, Int32 level, Int32 layer)
        {
            this.CallVoidMethod("framebufferTextureLayer", target, attachment, texture, level, layer);
        }
        
        public void InvalidateFramebuffer(UInt32 target, UInt32[] attachments)
        {
            this.CallVoidMethod("invalidateFramebuffer", target, attachments);
        }
        
        public void InvalidateSubFramebuffer(UInt32 target, UInt32[] attachments, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            this.CallVoidMethod("invalidateSubFramebuffer", target, attachments, x, y, width, height);
        }
        
        public void ReadBuffer(UInt32 src)
        {
            this.CallVoidMethod("readBuffer", src);
        }
        
        public object GetInternalformatParameter(UInt32 target, UInt32 internalformat, UInt32 pname)
        {
            return this.CallMethod<object>("getInternalformatParameter", target, internalformat, pname);
        }
        
        public void RenderbufferStorageMultisample(UInt32 target, Int32 samples, UInt32 internalformat, Int32 width, Int32 height)
        {
            this.CallVoidMethod("renderbufferStorageMultisample", target, samples, internalformat, width, height);
        }
        
        public void TexStorage2D(UInt32 target, Int32 levels, UInt32 internalformat, Int32 width, Int32 height)
        {
            this.CallVoidMethod("texStorage2D", target, levels, internalformat, width, height);
        }
        
        public void TexStorage3D(UInt32 target, Int32 levels, UInt32 internalformat, Int32 width, Int32 height, Int32 depth)
        {
            this.CallVoidMethod("texStorage3D", target, levels, internalformat, width, height, depth);
        }
        
        public void TexImage3D(UInt32 target, Int32 level, UInt32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, UInt32 format, UInt32 type, IntPtr pixels)
        {
            this.CallVoidMethod("texImage3D", target, level, internalformat, width, height, depth, border, format, type, pixels);
        }
        
        public void TexSubImage3D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, UInt32 format, UInt32 type, IntPtr pixels)
        {
            this.CallVoidMethod("texSubImage3D", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }
        
        public void TexSubImage3D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, UInt32 format, UInt32 type, nsISupports data)
        {
            this.CallVoidMethod("texSubImage3D", target, level, xoffset, yoffset, zoffset, format, type, data);
        }
        
        public void TexSubImage3D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, UInt32 format, UInt32 type, nsIDOMHTMLImageElement image)
        {
            this.CallVoidMethod("texSubImage3D", target, level, xoffset, yoffset, zoffset, format, type, image);
        }
        
        public void TexSubImage3D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, UInt32 format, UInt32 type, nsIDOMHTMLCanvasElement canvas)
        {
            this.CallVoidMethod("texSubImage3D", target, level, xoffset, yoffset, zoffset, format, type, canvas);
        }
        
        public void CopyTexSubImage3D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            this.CallVoidMethod("copyTexSubImage3D", target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }
        
        public void CompressedTexImage3D(UInt32 target, Int32 level, UInt32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, IntPtr data)
        {
            this.CallVoidMethod("compressedTexImage3D", target, level, internalformat, width, height, depth, border, data);
        }
        
        public void CompressedTexSubImage3D(UInt32 target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, UInt32 format, IntPtr data)
        {
            this.CallVoidMethod("compressedTexSubImage3D", target, level, xoffset, yoffset, zoffset, width, height, depth, format, data);
        }
        
        public Int32 GetFragDataLocation(nsISupports program, string name)
        {
            return this.CallMethod<Int32>("getFragDataLocation", program, name);
        }
        
        public void Uniform1ui(nsISupports location, UInt32 v0)
        {
            this.CallVoidMethod("uniform1ui", location, v0);
        }
        
        public void Uniform2ui(nsISupports location, UInt32 v0, UInt32 v1)
        {
            this.CallVoidMethod("uniform2ui", location, v0, v1);
        }
        
        public void Uniform3ui(nsISupports location, UInt32 v0, UInt32 v1, UInt32 v2)
        {
            this.CallVoidMethod("uniform3ui", location, v0, v1, v2);
        }
        
        public void Uniform4ui(nsISupports location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
        {
            this.CallVoidMethod("uniform4ui", location, v0, v1, v2, v3);
        }
        
        public void Uniform1uiv(nsISupports location, IntPtr value)
        {
            this.CallVoidMethod("uniform1uiv", location, value);
        }
        
        public void Uniform1uiv(nsISupports location, UInt32[] value)
        {
            this.CallVoidMethod("uniform1uiv", location, value);
        }
        
        public void Uniform2uiv(nsISupports location, IntPtr value)
        {
            this.CallVoidMethod("uniform2uiv", location, value);
        }
        
        public void Uniform2uiv(nsISupports location, UInt32[] value)
        {
            this.CallVoidMethod("uniform2uiv", location, value);
        }
        
        public void Uniform3uiv(nsISupports location, IntPtr value)
        {
            this.CallVoidMethod("uniform3uiv", location, value);
        }
        
        public void Uniform3uiv(nsISupports location, UInt32[] value)
        {
            this.CallVoidMethod("uniform3uiv", location, value);
        }
        
        public void Uniform4uiv(nsISupports location, IntPtr value)
        {
            this.CallVoidMethod("uniform4uiv", location, value);
        }
        
        public void Uniform4uiv(nsISupports location, UInt32[] value)
        {
            this.CallVoidMethod("uniform4uiv", location, value);
        }
        
        public void UniformMatrix2x3fv(nsISupports location, Boolean transpose, IntPtr value)
        {
            this.CallVoidMethod("uniformMatrix2x3fv", location, transpose, value);
        }
        
        public void UniformMatrix2x3fv(nsISupports location, Boolean transpose, Single[] value)
        {
            this.CallVoidMethod("uniformMatrix2x3fv", location, transpose, value);
        }
        
        public void UniformMatrix3x2fv(nsISupports location, Boolean transpose, IntPtr value)
        {
            this.CallVoidMethod("uniformMatrix3x2fv", location, transpose, value);
        }
        
        public void UniformMatrix3x2fv(nsISupports location, Boolean transpose, Single[] value)
        {
            this.CallVoidMethod("uniformMatrix3x2fv", location, transpose, value);
        }
        
        public void UniformMatrix2x4fv(nsISupports location, Boolean transpose, IntPtr value)
        {
            this.CallVoidMethod("uniformMatrix2x4fv", location, transpose, value);
        }
        
        public void UniformMatrix2x4fv(nsISupports location, Boolean transpose, Single[] value)
        {
            this.CallVoidMethod("uniformMatrix2x4fv", location, transpose, value);
        }
        
        public void UniformMatrix4x2fv(nsISupports location, Boolean transpose, IntPtr value)
        {
            this.CallVoidMethod("uniformMatrix4x2fv", location, transpose, value);
        }
        
        public void UniformMatrix4x2fv(nsISupports location, Boolean transpose, Single[] value)
        {
            this.CallVoidMethod("uniformMatrix4x2fv", location, transpose, value);
        }
        
        public void UniformMatrix3x4fv(nsISupports location, Boolean transpose, IntPtr value)
        {
            this.CallVoidMethod("uniformMatrix3x4fv", location, transpose, value);
        }
        
        public void UniformMatrix3x4fv(nsISupports location, Boolean transpose, Single[] value)
        {
            this.CallVoidMethod("uniformMatrix3x4fv", location, transpose, value);
        }
        
        public void UniformMatrix4x3fv(nsISupports location, Boolean transpose, IntPtr value)
        {
            this.CallVoidMethod("uniformMatrix4x3fv", location, transpose, value);
        }
        
        public void UniformMatrix4x3fv(nsISupports location, Boolean transpose, Single[] value)
        {
            this.CallVoidMethod("uniformMatrix4x3fv", location, transpose, value);
        }
        
        public void VertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
        {
            this.CallVoidMethod("vertexAttribI4i", index, x, y, z, w);
        }
        
        public void VertexAttribI4iv(UInt32 index, Int32[] v)
        {
            this.CallVoidMethod("vertexAttribI4iv", index, v);
        }
        
        public void VertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
        {
            this.CallVoidMethod("vertexAttribI4ui", index, x, y, z, w);
        }
        
        public void VertexAttribI4uiv(UInt32 index, UInt32[] v)
        {
            this.CallVoidMethod("vertexAttribI4uiv", index, v);
        }
        
        public void VertexAttribIPointer(UInt32 index, Int32 size, UInt32 type, Int32 stride, Int64 offset)
        {
            this.CallVoidMethod("vertexAttribIPointer", index, size, type, stride, offset);
        }
        
        public void VertexAttribDivisor(UInt32 index, UInt32 divisor)
        {
            this.CallVoidMethod("vertexAttribDivisor", index, divisor);
        }
        
        public void DrawArraysInstanced(UInt32 mode, Int32 first, Int32 count, Int32 instanceCount)
        {
            this.CallVoidMethod("drawArraysInstanced", mode, first, count, instanceCount);
        }
        
        public void DrawElementsInstanced(UInt32 mode, Int32 count, UInt32 type, Int64 offset, Int32 instanceCount)
        {
            this.CallVoidMethod("drawElementsInstanced", mode, count, type, offset, instanceCount);
        }
        
        public void DrawRangeElements(UInt32 mode, UInt32 start, UInt32 end, Int32 count, UInt32 type, Int64 offset)
        {
            this.CallVoidMethod("drawRangeElements", mode, start, end, count, type, offset);
        }
        
        public void DrawBuffers(UInt32[] buffers)
        {
            this.CallVoidMethod("drawBuffers", buffers);
        }
        
        public void ClearBufferiv(UInt32 buffer, Int32 drawbuffer, IntPtr value)
        {
            this.CallVoidMethod("clearBufferiv", buffer, drawbuffer, value);
        }
        
        public void ClearBufferiv(UInt32 buffer, Int32 drawbuffer, Int32[] value)
        {
            this.CallVoidMethod("clearBufferiv", buffer, drawbuffer, value);
        }
        
        public void ClearBufferuiv(UInt32 buffer, Int32 drawbuffer, IntPtr value)
        {
            this.CallVoidMethod("clearBufferuiv", buffer, drawbuffer, value);
        }
        
        public void ClearBufferuiv(UInt32 buffer, Int32 drawbuffer, UInt32[] value)
        {
            this.CallVoidMethod("clearBufferuiv", buffer, drawbuffer, value);
        }
        
        public void ClearBufferfv(UInt32 buffer, Int32 drawbuffer, IntPtr value)
        {
            this.CallVoidMethod("clearBufferfv", buffer, drawbuffer, value);
        }
        
        public void ClearBufferfv(UInt32 buffer, Int32 drawbuffer, Single[] value)
        {
            this.CallVoidMethod("clearBufferfv", buffer, drawbuffer, value);
        }
        
        public void ClearBufferfi(UInt32 buffer, Int32 drawbuffer, Single depth, Int32 stencil)
        {
            this.CallVoidMethod("clearBufferfi", buffer, drawbuffer, depth, stencil);
        }
        
        public nsISupports CreateQuery()
        {
            return this.CallMethod<nsISupports>("createQuery");
        }
        
        public void DeleteQuery(nsISupports query)
        {
            this.CallVoidMethod("deleteQuery", query);
        }
        
        public Boolean IsQuery(nsISupports query)
        {
            return this.CallMethod<Boolean>("isQuery", query);
        }
        
        public void BeginQuery(UInt32 target, nsISupports query)
        {
            this.CallVoidMethod("beginQuery", target, query);
        }
        
        public void EndQuery(UInt32 target)
        {
            this.CallVoidMethod("endQuery", target);
        }
        
        public nsISupports GetQuery(UInt32 target, UInt32 pname)
        {
            return this.CallMethod<nsISupports>("getQuery", target, pname);
        }
        
        public object GetQueryParameter(nsISupports query, UInt32 pname)
        {
            return this.CallMethod<object>("getQueryParameter", query, pname);
        }
        
        public nsISupports CreateSampler()
        {
            return this.CallMethod<nsISupports>("createSampler");
        }
        
        public void DeleteSampler(nsISupports sampler)
        {
            this.CallVoidMethod("deleteSampler", sampler);
        }
        
        public Boolean IsSampler(nsISupports sampler)
        {
            return this.CallMethod<Boolean>("isSampler", sampler);
        }
        
        public void BindSampler(UInt32 unit, nsISupports sampler)
        {
            this.CallVoidMethod("bindSampler", unit, sampler);
        }
        
        public void SamplerParameteri(nsISupports sampler, UInt32 pname, Int32 param)
        {
            this.CallVoidMethod("samplerParameteri", sampler, pname, param);
        }
        
        public void SamplerParameterf(nsISupports sampler, UInt32 pname, Single param)
        {
            this.CallVoidMethod("samplerParameterf", sampler, pname, param);
        }
        
        public object GetSamplerParameter(nsISupports sampler, UInt32 pname)
        {
            return this.CallMethod<object>("getSamplerParameter", sampler, pname);
        }
        
        public nsISupports FenceSync(UInt32 condition, UInt32 flags)
        {
            return this.CallMethod<nsISupports>("fenceSync", condition, flags);
        }
        
        public Boolean IsSync(nsISupports sync)
        {
            return this.CallMethod<Boolean>("isSync", sync);
        }
        
        public void DeleteSync(nsISupports sync)
        {
            this.CallVoidMethod("deleteSync", sync);
        }
        
        public UInt32 ClientWaitSync(nsISupports sync, UInt32 flags, Int64 timeout)
        {
            return this.CallMethod<UInt32>("clientWaitSync", sync, flags, timeout);
        }
        
        public void WaitSync(nsISupports sync, UInt32 flags, Int64 timeout)
        {
            this.CallVoidMethod("waitSync", sync, flags, timeout);
        }
        
        public object GetSyncParameter(nsISupports sync, UInt32 pname)
        {
            return this.CallMethod<object>("getSyncParameter", sync, pname);
        }
        
        public nsISupports CreateTransformFeedback()
        {
            return this.CallMethod<nsISupports>("createTransformFeedback");
        }
        
        public void DeleteTransformFeedback(nsISupports tf)
        {
            this.CallVoidMethod("deleteTransformFeedback", tf);
        }
        
        public Boolean IsTransformFeedback(nsISupports tf)
        {
            return this.CallMethod<Boolean>("isTransformFeedback", tf);
        }
        
        public void BindTransformFeedback(UInt32 target, nsISupports tf)
        {
            this.CallVoidMethod("bindTransformFeedback", target, tf);
        }
        
        public void BeginTransformFeedback(UInt32 primitiveMode)
        {
            this.CallVoidMethod("beginTransformFeedback", primitiveMode);
        }
        
        public void EndTransformFeedback()
        {
            this.CallVoidMethod("endTransformFeedback");
        }
        
        public void TransformFeedbackVaryings(nsISupports program, string[] varyings, UInt32 bufferMode)
        {
            this.CallVoidMethod("transformFeedbackVaryings", program, varyings, bufferMode);
        }
        
        public nsISupports GetTransformFeedbackVarying(nsISupports program, UInt32 index)
        {
            return this.CallMethod<nsISupports>("getTransformFeedbackVarying", program, index);
        }
        
        public void PauseTransformFeedback()
        {
            this.CallVoidMethod("pauseTransformFeedback");
        }
        
        public void ResumeTransformFeedback()
        {
            this.CallVoidMethod("resumeTransformFeedback");
        }
        
        public void BindBufferBase(UInt32 target, UInt32 index, nsISupports buffer)
        {
            this.CallVoidMethod("bindBufferBase", target, index, buffer);
        }
        
        public void BindBufferRange(UInt32 target, UInt32 index, nsISupports buffer, Int64 offset, Int64 size)
        {
            this.CallVoidMethod("bindBufferRange", target, index, buffer, offset, size);
        }
        
        public WebIDLUnion<nsISupports,Int64> GetIndexedParameter(UInt32 target, UInt32 index)
        {
            return this.CallMethod<WebIDLUnion<nsISupports,Int64>>("getIndexedParameter", target, index);
        }
        
        public UInt32[] GetUniformIndices(nsISupports program, string[] uniformNames)
        {
            return this.CallMethod<UInt32[]>("getUniformIndices", program, uniformNames);
        }
        
        public Int32[] GetActiveUniforms(nsISupports program, UInt32[] uniformIndices, UInt32 pname)
        {
            return this.CallMethod<Int32[]>("getActiveUniforms", program, uniformIndices, pname);
        }
        
        public UInt32 GetUniformBlockIndex(nsISupports program, string uniformBlockName)
        {
            return this.CallMethod<UInt32>("getUniformBlockIndex", program, uniformBlockName);
        }
        
        public WebIDLUnion<UInt32,IntPtr,Boolean> GetActiveUniformBlockParameter(nsISupports program, UInt32 uniformBlockIndex, UInt32 pname)
        {
            return this.CallMethod<WebIDLUnion<UInt32,IntPtr,Boolean>>("getActiveUniformBlockParameter", program, uniformBlockIndex, pname);
        }
        
        public string GetActiveUniformBlockName(nsISupports program, UInt32 uniformBlockIndex)
        {
            return this.CallMethod<string>("getActiveUniformBlockName", program, uniformBlockIndex);
        }
        
        public void UniformBlockBinding(nsISupports program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding)
        {
            this.CallVoidMethod("uniformBlockBinding", program, uniformBlockIndex, uniformBlockBinding);
        }
        
        public nsISupports CreateVertexArray()
        {
            return this.CallMethod<nsISupports>("createVertexArray");
        }
        
        public void DeleteVertexArray(nsISupports vertexArray)
        {
            this.CallVoidMethod("deleteVertexArray", vertexArray);
        }
        
        public Boolean IsVertexArray(nsISupports vertexArray)
        {
            return this.CallMethod<Boolean>("isVertexArray", vertexArray);
        }
        
        public void BindVertexArray(nsISupports array)
        {
            this.CallVoidMethod("bindVertexArray", array);
        }
    }
}
