﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

/*
 * Task Execution Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.3.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Tes.Models
{
    /// <summary>
    /// Executor describes a command to be executed, and its environment.
    /// </summary>
    [DataContract]
    public partial class TesExecutor : IEquatable<TesExecutor>
    {
        public TesExecutor()
        {
            Common.NewtonsoftJsonSafeInit.SetDefaultSettings();
        }

        /// <summary>
        /// Name of the container image, for example: ubuntu quay.io/aptible/ubuntu gcr.io/my-org/my-image etc...
        /// </summary>
        /// <value>Name of the container image, for example: ubuntu quay.io/aptible/ubuntu gcr.io/my-org/my-image etc...</value>
        [DataMember(Name = "image")]
        public string Image { get; set; }

        /// <summary>
        /// A sequence of program arguments to execute, where the first argument is the program to execute (i.e. argv).
        /// </summary>
        /// <value>A sequence of program arguments to execute, where the first argument is the program to execute (i.e. argv).</value>
        [DataMember(Name = "command")]
        public List<string> Command { get; set; }

        /// <summary>
        /// The working directory that the command will be executed in. Defaults to the directory set by the container image.
        /// </summary>
        /// <value>The working directory that the command will be executed in. Defaults to the directory set by the container image.</value>
        [DataMember(Name = "workdir")]
        public string Workdir { get; set; }

        /// <summary>
        /// Path inside the container to a file which will be piped to the executor&#39;s stdin. Must be an absolute path.
        /// </summary>
        /// <value>Path inside the container to a file which will be piped to the executor&#39;s stdin. Must be an absolute path.</value>
        [DataMember(Name = "stdin")]
        public string Stdin { get; set; }

        /// <summary>
        /// Path inside the container to a file where the executor&#39;s stdout will be written to. Must be an absolute path.
        /// </summary>
        /// <value>Path inside the container to a file where the executor&#39;s stdout will be written to. Must be an absolute path.</value>
        [DataMember(Name = "stdout")]
        public string Stdout { get; set; }

        /// <summary>
        /// Path inside the container to a file where the executor&#39;s stderr will be written to. Must be an absolute path.
        /// </summary>
        /// <value>Path inside the container to a file where the executor&#39;s stderr will be written to. Must be an absolute path.</value>
        [DataMember(Name = "stderr")]
        public string Stderr { get; set; }

        /// <summary>
        /// Enviromental variables to set within the container.
        /// </summary>
        /// <value>Enviromental variables to set within the container.</value>
        [DataMember(Name = "env")]
        public Dictionary<string, string> Env { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
            => new StringBuilder()
                .Append("class TesExecutor {\n")
                .Append("  Image: ").Append(Image).Append('\n')
                .Append("  Command: ").Append(Command).Append('\n')
                .Append("  Workdir: ").Append(Workdir).Append('\n')
                .Append("  Stdin: ").Append(Stdin).Append('\n')
                .Append("  Stdout: ").Append(Stdout).Append('\n')
                .Append("  Stderr: ").Append(Stderr).Append('\n')
                .Append("  Env: ").Append(Env).Append('\n')
                .Append("}\n")
                .ToString();

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
            => JsonConvert.SerializeObject(this, Formatting.Indented);

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
            => obj switch
            {
                var x when x is null => false,
                var x when ReferenceEquals(this, x) => true,
                _ => obj.GetType() == GetType() && Equals((TesExecutor)obj),
            };

        /// <summary>
        /// Returns true if TesExecutor instances are equal
        /// </summary>
        /// <param name="other">Instance of TesExecutor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TesExecutor other)
            => other switch
            {
                var x when x is null => false,
                var x when ReferenceEquals(this, x) => true,
                _ =>
                (
                    Image == other.Image ||
                    Image is not null &&
                    Image.Equals(other.Image)
                ) &&
                (
                    Command == other.Command ||
                    Command is not null &&
                    Command.SequenceEqual(other.Command)
                ) &&
                (
                    Workdir == other.Workdir ||
                    Workdir is not null &&
                    Workdir.Equals(other.Workdir)
                ) &&
                (
                    Stdin == other.Stdin ||
                    Stdin is not null &&
                    Stdin.Equals(other.Stdin)
                ) &&
                (
                    Stdout == other.Stdout ||
                    Stdout is not null &&
                    Stdout.Equals(other.Stdout)
                ) &&
                (
                    Stderr == other.Stderr ||
                    Stderr is not null &&
                    Stderr.Equals(other.Stderr)
                ) &&
                (
                    Env == other.Env ||
                    Env is not null &&
                    Env.SequenceEqual(other.Env)
                ),
            };

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (Image is not null)
                {
                    hashCode = hashCode * 59 + Image.GetHashCode();
                }

                if (Command is not null)
                {
                    hashCode = hashCode * 59 + Command.GetHashCode();
                }

                if (Workdir is not null)
                {
                    hashCode = hashCode * 59 + Workdir.GetHashCode();
                }

                if (Stdin is not null)
                {
                    hashCode = hashCode * 59 + Stdin.GetHashCode();
                }

                if (Stdout is not null)
                {
                    hashCode = hashCode * 59 + Stdout.GetHashCode();
                }

                if (Stderr is not null)
                {
                    hashCode = hashCode * 59 + Stderr.GetHashCode();
                }

                if (Env is not null)
                {
                    hashCode = hashCode * 59 + Env.GetHashCode();
                }

                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(TesExecutor left, TesExecutor right)
            => Equals(left, right);

        public static bool operator !=(TesExecutor left, TesExecutor right)
            => !Equals(left, right);

#pragma warning restore 1591
        #endregion Operators
    }
}
