﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RollingInterval.cs" company="SeppPenner and the Serilog contributors">
// The project is double licensed under the MIT license and the Apache License, Version 2.0.
// This code is a partly modified source code of the original Serilog code.
// The original license is:
//
// --------------------------------------------------------------------------------------------------------------------
// Copyright 2013-2016 Serilog Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// --------------------------------------------------------------------------------------------------------------------
//
// </copyright>
// <summary>
//   Specifies the frequency at which the log file should roll.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Serilog.Sinks.AmazonS3
{
    /// <summary>
    /// Specifies the frequency at which the log file should roll.
    /// </summary>
    public enum RollingInterval
    {
        /// <summary>
        /// The log file will never roll; no time period information will be appended to the log file name.
        /// </summary>
        Infinite,

        /// <summary>
        /// Roll every year. File names will have a four-digit year appended in the pattern <code>yyyy</code>.
        /// </summary>
        Year,

        /// <summary>
        /// Roll every calendar month. File names will have <code>yyyyMM</code> appended.
        /// </summary>
        Month,

        /// <summary>
        /// Roll every day. File names will have <code>yyyyMMdd</code> appended.
        /// </summary>
        Day,

        /// <summary>
        /// Roll every hour. File names will have <code>yyyyMMddHH</code> appended.
        /// </summary>
        Hour,

        /// <summary>
        /// Roll every minute. File names will have <code>yyyyMMddHHmm</code> appended.
        /// </summary>
        Minute
    }
}
