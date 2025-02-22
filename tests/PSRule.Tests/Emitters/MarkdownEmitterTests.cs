// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation;

namespace PSRule.Emitters;

/// <summary>
/// Unit tests for <see cref="MarkdownEmitter"/>.
/// </summary>
public sealed class MarkdownEmitterTests : EmitterTests
{
    [Fact]
    public void Accepts_WhenValidType_ShouldReturnTrue()
    {
        var context = new TestEmitterContext();
        var emitter = new MarkdownEmitter(EmptyEmitterConfiguration.Instance);

        Assert.True(emitter.Accepts(context, typeof(InternalFileInfo)));
        Assert.True(emitter.Accepts(context, typeof(string)));
        Assert.False(emitter.Accepts(null, null));
        Assert.False(emitter.Accepts(context, typeof(object)));
    }

    [Fact]
    public void Visit_WhenValidFile_ShouldVisitDefaultTypes()
    {
        var context = new TestEmitterContext();
        var emitter = new MarkdownEmitter(EmptyEmitterConfiguration.Instance);

        Assert.True(emitter.Visit(context, GetFileInfo("ObjectFromFile.md")));
        Assert.True(emitter.Visit(context, GetFileInfo("ObjectFromFile.markdown")));
        Assert.False(emitter.Visit(context, GetFileInfo("ObjectFromFile.yaml")));
        Assert.False(emitter.Visit(context, new InternalFileInfo("", "")));
        Assert.False(emitter.Visit(null, null));

        Assert.Equal(2, context.Items.Count);
    }

    [Fact]
    public void Visit_WhenEmptyFile_ShouldNotEmitItems()
    {
        var context = new TestEmitterContext();
        var emitter = new MarkdownEmitter(EmptyEmitterConfiguration.Instance);

        Assert.True(emitter.Visit(context, GetFileInfo("ObjectFromFileEmpty.md")));
        Assert.Empty(context.Items);
    }

    [Fact]
    public void Visit_WhenReplacementConfigured_ShouldReplaceTokens()
    {
        var context = new TestEmitterContext();
        var emitter = new MarkdownEmitter(GetEmitterConfiguration(format: [("markdown", default, default, [new KeyValuePair<string, string>("kind: Test", "kind: ReplacementTest")])]));

        Assert.True(emitter.Visit(context, GetFileInfo("ObjectFromFile.md")));

        var item = context.Items[0].Value as PSObject;
        var spec = item.Properties["spec"].Value as PSObject;
        var properties = spec.Properties["properties"].Value as PSObject;
        Assert.Equal("ReplacementTest", properties.Properties["kind"].Value);
    }

    [Fact]
    public void Visit_WhenString_ShouldEmitItems()
    {
        var context = new TestEmitterContext(stringFormat: "markdown");
        var emitter = new MarkdownEmitter(EmptyEmitterConfiguration.Instance);

        // With format.
        Assert.True(emitter.Visit(context, ReadFileAsString("ObjectFromFile.md")));
        Assert.Single(context.Items);

        // Without format.
        context = new TestEmitterContext();
        Assert.False(emitter.Visit(context, ReadFileAsString("ObjectFromFile.md")));
    }
}
