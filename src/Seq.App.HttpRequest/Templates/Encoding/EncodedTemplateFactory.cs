﻿using System;
using Seq.App.HttpRequest.Expressions;
using Seq.App.HttpRequest.Templates.Compilation;
using Serilog.Parsing;

namespace Seq.App.HttpRequest.Templates.Encoding
{
    class EncodedTemplateFactory
    {
        readonly TemplateOutputEncoder? _encoder;

        public EncodedTemplateFactory(TemplateOutputEncoder? encoder)
        {
            _encoder = encoder;
        }
        
        public CompiledTemplate Wrap(CompiledTemplate inner)
        {
            if (_encoder == null)
                return inner;

            return new EncodedCompiledTemplate(inner, _encoder);
        }
        
        public CompiledTemplate MakeCompiledFormattedExpression(Evaluatable expression, string? format, Alignment? alignment, IFormatProvider? formatProvider)
        {
            if (_encoder == null)
                return new CompiledFormattedExpression(expression, format, alignment, formatProvider);
            
            return new EscapableEncodedCompiledFormattedExpression(expression, format, alignment, formatProvider, _encoder);
        }
    }
}