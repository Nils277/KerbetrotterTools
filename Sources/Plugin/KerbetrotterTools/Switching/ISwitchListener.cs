﻿/*
 * Copyright (C) 2021 Nils277 (https://github.com/Nils277)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace KerbetrotterTools
{
    /// <summary>
    /// Listener interface for switching
    /// </summary>
    public interface ISwitchListener
    {
        /// <summary>
        /// Get the setup group of the switchlistener 
        /// </summary>
        /// <returns>The setup group</returns>
        string getSetup();
        
        /// <summary>
        /// Change the setup of the switch
        /// </summary>
        /// <param name="setup">The name of the new setup</param>
        void onSwitch(string setup);
    }
}
