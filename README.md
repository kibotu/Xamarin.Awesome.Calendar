# Xamarin.Awesome.Calendar [![NuGet Badge](https://buildstats.info/nuget/Xamarin.Awesome.Calendar)](https://www.nuget.org/packages/Xamarin.Awesome.Calendar/) [![Build Status](https://app.bitrise.io/app/f16178539ab449e6/status.svg?token=jKIYZPzRgFwEAFb2099GpQ&branch=master)](https://app.bitrise.io/app/f16178539ab449e6)

Port of https://github.com/ArchitShah248/CalendarDateRangePicker to Xamarin.

# How to use

Have a look at [README.md](https://github.com/ArchitShah248/CalendarDateRangePicker/blob/master/README.md)

An Android Library to pick dates range, that helps user to select range from future dates.

## How to install

### Android

Add [Xamarin.Awesome.Calendar](https://www.nuget.org/packages/Xamarin.Awesome.Calendar)

        PM> Install-Package Xamarin.Awesome.Calendar -Version 1.1.1

## How to build

    msbuild Xamarin.Awesome.Calendar.sln /t:Xamarin.Awesome.Calendar /p:Configuration="Release" /p:BuildProjectReferences=false

# CalendarDateRangePicker

**Features:**

- Date selection
- Swipe to change month
- Full customization
- Small in size
- Material design support
- Resolution support

Screenshots
-----------

<img width="30%" src="https://raw.githubusercontent.com/ArchitShah248/CalendarDateRangePicker/master/screenshots/device-2017-08-14-143753.png" />
<img width="30%" src="https://raw.githubusercontent.com/ArchitShah248/CalendarDateRangePicker/master/screenshots/device-2017-08-14-143933.png" />


Developer setup
---------------

**Import DateRangePicker dependency**


For Gradle:

Add following line to App level gradle:
```
dependencies {
    compile 'com.archit.calendar:awesome-calendar:1.1.1'
}
```


For Maven:
```xml
<dependency>
  <groupId>com.archit.calendar</groupId>
  <artifactId>awesome-calendar</artifactId>
  <version>1.1.1</version>
  <type>pom</type>
</dependency>
```

**Usage**
---------------
````xml
<com.archit.calendardaterangepicker.customviews.DateRangeCalendarView
             android:id="@+id/calendar"
             android:layout_width="wrap_content"
             android:layout_height="wrap_content"
             custom:disable_date_color="#ABABAB"
             custom:header_bg="@drawable/calendar_header"
             custom:range_color="@color/range_color"
             custom:selected_date_circle_color="@color/selected_date_circle_color"
             custom:title_color="@color/calendar_header_title">
</com.archit.calendardaterangepicker.customviews.DateRangeCalendarView>
````


**XML Attribute set**
------------------

| Attribute                  | Type      | Desciption                         |
| :------------------------- | --------- | ---------------------------------- |
| title_color                | Color     | Title color                        |
| week_color                 | Color     | Week text color                    |
| range_color                | Color     | Date range color                   |
| selected_date_circle_color | Color     | Selected date text circle color         |
| selected_date_color        | Color     | Selected date text color                |
| default_date_color         | Color     | Default date text color                 |
| range_date_color           | Color     | Date text color when it falls into range |
| disable_date_color         | Color     | Disable date color                 |
| enable_time_selection      | Boolean   | true to enable time selection else false    |
| text_size_title            | Dimension | Title size                         |
| text_size_week             | Dimension | Week text size                     |
| text_size_date             | Dimension | Date text size                     |
| header_bg                  | Drawable  | Header background                  |
| week_offset                | Dimension | To set week start day offset                  |


**Set callbacks**
````Java
public interface CalendarListener {
        void onFirstDateSelected(Calendar startDate);
        void onDateRangeSelected(Calendar startDate, Calendar endDate);
}
````
````Java
calendar.setCalendarListener(new DateRangeCalendarView.CalendarListener() {
    @Override
            public void onFirstDateSelected(Calendar startDate) {
                Toast.makeText(MainActivity.this, "Start Date: " + startDate.getTime().toString(), Toast.LENGTH_SHORT).show();
            }

            @Override
            public void onDateRangeSelected(Calendar startDate, Calendar endDate) {
                Toast.makeText(MainActivity.this, "Start Date: " + startDate.getTime().toString() + " End date: " + endDate.getTime().toString(), Toast.LENGTH_SHORT).show();
            }
});
````


**Reset calendar date selection**
````Java
calendar.resetAllSelectedViews();
`````


**Set text fonts**
````Java
Typeface typeface = Typeface.createFromAsset(getAssets(), "Roboto.ttf");
calendar.setFonts(typeface);
`````

**Set week offset ( 0-Sun, 1-Mon, 2-Tue, 3-Wed, 4-Thu, 5-Fri, 6-Sat )**
````Java
calendar.setWeekOffset(1);
`````


### Please help me in making it best by reporting issue or posting any fetaure extension.

### Requirements

- Java 7
- Latest version of Android SDK and Android Build Tools


License
-------

    Copyright 2017 Archit Shah

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
