# Customize-the-numerical-axis-in-.NET-MAUI-Cartesian-Chart
This sample demonstrate how to customize the numerical axis in .NET MAUI Cartesian Chart.

A quick-start example to help you to customize the numerical axis of the Syncfusion .NET MAUI Cartesian Chart. You will learn how to add a numerical axis to a Cartesian Charts, customize its interval, range, and range padding. You'll also learn how to invert and hide the axis. 

Watch the video: Coming soon...

Documentation: https://help.syncfusion.com/maui/cartesian-charts/axis/types#numerical-axis

## Customizing the Range
Maximum and Minimum properties of axis is used for setting the maximum and minimum value of the axis range respectively.

```
<chart:SfCartesianChart.YAxes>
    <chart:NumericalAxis Maximum="2750" Minimum="250" Interval="250"/>
</chart:SfCartesianChart.YAxes>
```

## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

To run the sample demo, refer to [System Requirements for .NET MAUI.](https://help.syncfusion.com/maui/system-requirements)

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
