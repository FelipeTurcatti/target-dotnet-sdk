/*
 * Copyright 2020 Adobe. All rights reserved.
 * This file is licensed to you under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License. You may obtain a copy
 * of the License at http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR REPRESENTATIONS
 * OF ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 */
namespace Adobe.Target.Client
{
    using System;
    using Adobe.Target.Client.Service;

    /// <summary>
    /// The main TargetClient class
    /// Contains methods for creating and using TargetClient SDK
    /// </summary>
    public class TargetClient : ITargetClient
    {
        private TargetService targetService;

        /// <summary>
        /// Initializes an ITargetClient using provided Target configuration
        /// </summary>
        /// <param name="clientConfig">Target <see cref="ClientConfig"/></param>
        public void Initialize(ClientConfig clientConfig)
        {
            this.targetService = new TargetService(clientConfig);
            Console.WriteLine("Initialized " + clientConfig.OrganizationId);
        }

        /// <summary>
        /// Test method
        /// </summary>
        /// <returns>
        /// A test value
        /// </returns>
        public int TestMe()
        {
            return 1;
        }
    }
}
