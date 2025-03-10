// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using PSRule.Data;

namespace PSRule.Emitters;

/// <summary>
/// Contains context for an <see cref="IEmitter"/>.
/// </summary>
public interface IEmitterContext
{
    /// <summary>
    /// The format that will be used to convert string types.
    /// </summary>
    string? StringFormat { get; }

    /// <summary>
    /// Determines if file are emitted for processing.
    /// This is for backwards compatibility and will be removed for v4.
    /// </summary>
    bool ShouldEmitFile { get; }

    /// <summary>
    /// Emit a target object to the pipeline.
    /// </summary>
    /// <param name="value">The <seealso cref="ITargetObject"/> to emit.</param>
    void Emit(ITargetObject value);

    /// <summary>
    /// Determine if a specified path should be queued for processing.
    /// </summary>
    bool ShouldQueue(string path);
}
