// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AnomalyAlertingConfiguration. </summary>
    public partial class AnomalyAlertConfiguration
    {

        /// <summary> Initializes a new instance of AnomalyAlertConfiguration. </summary>
        /// <param name="id"> anomaly alerting configuration unique id. </param>
        /// <param name="name"> anomaly alerting configuration name. </param>
        /// <param name="description"> anomaly alerting configuration description. </param>
        /// <param name="crossMetricsOperator">
        /// cross metrics operator
        /// 
        /// 
        /// 
        /// should be specified when setting up multiple metric alerting configurations.
        /// </param>
        /// <param name="idsOfHooksToAlert"> hook unique ids. </param>
        /// <param name="metricAlertConfigurations"> Anomaly alerting configurations. </param>
        internal AnomalyAlertConfiguration(string id, string name, string description, MetricAnomalyAlertConfigurationsOperator? crossMetricsOperator, IList<string> idsOfHooksToAlert, IList<MetricAnomalyAlertConfiguration> metricAlertConfigurations)
        {
            Id = id;
            Name = name;
            Description = description;
            CrossMetricsOperator = crossMetricsOperator;
            IdsOfHooksToAlert = idsOfHooksToAlert;
            MetricAlertConfigurations = metricAlertConfigurations;
        }
    }
}