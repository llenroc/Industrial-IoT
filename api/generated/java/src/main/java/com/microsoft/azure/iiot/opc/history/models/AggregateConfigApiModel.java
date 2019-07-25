/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package com.microsoft.azure.iiot.opc.history.models;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Aggregate configuration.
 */
public class AggregateConfigApiModel {
    /**
     * Whether to use the default server caps.
     */
    @JsonProperty(value = "useServerCapabilitiesDefaults")
    private Boolean useServerCapabilitiesDefaults;

    /**
     * Whether to treat uncertain as bad.
     */
    @JsonProperty(value = "treatUncertainAsBad")
    private Boolean treatUncertainAsBad;

    /**
     * Percent of data that is bad.
     */
    @JsonProperty(value = "percentDataBad")
    private Integer percentDataBad;

    /**
     * Percent of data that is good.
     */
    @JsonProperty(value = "percentDataGood")
    private Integer percentDataGood;

    /**
     * Whether to use sloped extrapolation.
     */
    @JsonProperty(value = "useSlopedExtrapolation")
    private Boolean useSlopedExtrapolation;

    /**
     * Get whether to use the default server caps.
     *
     * @return the useServerCapabilitiesDefaults value
     */
    public Boolean useServerCapabilitiesDefaults() {
        return this.useServerCapabilitiesDefaults;
    }

    /**
     * Set whether to use the default server caps.
     *
     * @param useServerCapabilitiesDefaults the useServerCapabilitiesDefaults value to set
     * @return the AggregateConfigApiModel object itself.
     */
    public AggregateConfigApiModel withUseServerCapabilitiesDefaults(Boolean useServerCapabilitiesDefaults) {
        this.useServerCapabilitiesDefaults = useServerCapabilitiesDefaults;
        return this;
    }

    /**
     * Get whether to treat uncertain as bad.
     *
     * @return the treatUncertainAsBad value
     */
    public Boolean treatUncertainAsBad() {
        return this.treatUncertainAsBad;
    }

    /**
     * Set whether to treat uncertain as bad.
     *
     * @param treatUncertainAsBad the treatUncertainAsBad value to set
     * @return the AggregateConfigApiModel object itself.
     */
    public AggregateConfigApiModel withTreatUncertainAsBad(Boolean treatUncertainAsBad) {
        this.treatUncertainAsBad = treatUncertainAsBad;
        return this;
    }

    /**
     * Get percent of data that is bad.
     *
     * @return the percentDataBad value
     */
    public Integer percentDataBad() {
        return this.percentDataBad;
    }

    /**
     * Set percent of data that is bad.
     *
     * @param percentDataBad the percentDataBad value to set
     * @return the AggregateConfigApiModel object itself.
     */
    public AggregateConfigApiModel withPercentDataBad(Integer percentDataBad) {
        this.percentDataBad = percentDataBad;
        return this;
    }

    /**
     * Get percent of data that is good.
     *
     * @return the percentDataGood value
     */
    public Integer percentDataGood() {
        return this.percentDataGood;
    }

    /**
     * Set percent of data that is good.
     *
     * @param percentDataGood the percentDataGood value to set
     * @return the AggregateConfigApiModel object itself.
     */
    public AggregateConfigApiModel withPercentDataGood(Integer percentDataGood) {
        this.percentDataGood = percentDataGood;
        return this;
    }

    /**
     * Get whether to use sloped extrapolation.
     *
     * @return the useSlopedExtrapolation value
     */
    public Boolean useSlopedExtrapolation() {
        return this.useSlopedExtrapolation;
    }

    /**
     * Set whether to use sloped extrapolation.
     *
     * @param useSlopedExtrapolation the useSlopedExtrapolation value to set
     * @return the AggregateConfigApiModel object itself.
     */
    public AggregateConfigApiModel withUseSlopedExtrapolation(Boolean useSlopedExtrapolation) {
        this.useSlopedExtrapolation = useSlopedExtrapolation;
        return this;
    }

}
