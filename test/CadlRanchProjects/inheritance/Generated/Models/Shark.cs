// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Models.Inheritance.Models
{
    /// <summary> The second level model in polymorphic multiple levels inheritance and it defines a new discriminator. </summary>
    public partial class Shark : Fish
    {
        /// <summary> Initializes a new instance of Shark. </summary>
        /// <param name="age"></param>
        public Shark(int age) : base("shark", age)
        {
        }
    }
}
