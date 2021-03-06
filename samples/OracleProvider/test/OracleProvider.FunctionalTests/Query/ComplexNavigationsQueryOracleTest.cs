﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Xunit.Abstractions;

// ReSharper disable InconsistentNaming
namespace Microsoft.EntityFrameworkCore.Query
{
    public class ComplexNavigationsQueryOracleTest : ComplexNavigationsQueryTestBase<ComplexNavigationsQueryOracleFixture>
    {
        public ComplexNavigationsQueryOracleTest(
            ComplexNavigationsQueryOracleFixture fixture, ITestOutputHelper testOutputHelper)
            : base(fixture)
        {
        }
    }
}
