/*
 * Copyright 2021 Adobe. All rights reserved.
 * This file is licensed to you under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License. You may obtain a copy
 * of the License at http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR REPRESENTATIONS
 * OF ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 */
namespace Adobe.Target.Client.Util
{
    internal static class Messages
    {
        internal const string ClientNotInitialized = "Target Client not initialized";
        internal const string ExecuteFieldsRequired = "Either PageLoad or Mboxes is required in Execute";
        internal const string PrefetchFieldsRequired = "Either Views, PageLoad or Mboxes is required in Prefetch";
        internal const string NotificationsRequired = "Notifications array is required in request";
        internal const string LogTargetServiceRequest = "Request IMSOrgId: {imsOrgId}, sessionId: {sessionId}, request: {request}";
        internal const string LogTargetServiceResponse = "Response: {response}";
    }
}
