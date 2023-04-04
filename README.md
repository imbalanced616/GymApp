# Программа "GymApp"
 Данная программа предназначена для подбора программы тренеровок.

Выполнили: Рылеев Александр Юрьевич и Мальчик Артём Вадимович


Обозреватель решений программы:

![SolutionExplorer](/Images/SolutionExplorer.png "Обозреватель решений (древо проекта)")


Интерфейсы приложения:

![Step1](/Images/Step1.png "Шаг 1/5")

![Step1Selected](/Images/Step1Selected.png "Шаг 1/5 с выбранной целью")

![Step2](/Images/Step2.png "Шаг 2/5")

![Step2Alert](/Images/Step2Alert.png "Шаг 2/5 с уведомлением")

![Step2Female](/Images/Step2Female.png "Шаг 2/5 с выбранным гендером: Женщина")

![Step3Female](/Images/Step3Female.png "Шаг 3/5: Женский вариант")

![Step3FemaleSelect](/Images/Step3FemaleSelect.png "Шаг 3/5: Женский вариант c выбранной частью тела")

![Step2Male](/Images/Step2Male.png "Шаг 2/5 с выбранным гендером: Мужчина")

![Step3Male](/Images/Step3Male.png "Шаг 3/5: Мужской вариант")

![Step3MaleSelect](/Images/Step3MaleSelect.png "Шаг 3/5: Мужской вариант c выбранной частью тела")

![Step4](/Images/Step4.png "Шаг 4/5")

![Step4Selected](/Images/Step4Selected.png "Шаг 4/5 с выбранным упражнением")

![Step5](/Images/Step5.png "Шаг 5/5")

![Step5Alert](/Images/Step5Alert.png "Шаг 5/5 с уведомлением")

![HomeGym](/Images/HomeGym.png "Страница авторизации")

![HomeGymWithData](/Images/HomeGymWithData.png "Страница авторизации с данными")


С помощью класса **"ClassHelper"**, в зависимости от выбора гендера на втором шаге, можно выбрать женский или мужской вариант тренеровок.

Описание класса **"Student"**:
```
namespace GymApp.Classes
{
    internal class ClassHelper
    {
        public static int ModeGender = 0;
    }
}
```

Описание внутренней части страницы **"PageStep1"** (с изменением цвета кнопок после нажатия):
```
using GymApp.Pages;

namespace GymApp;

public partial class PageStep1 : ContentPage
{
	public PageStep1()
	{
		InitializeComponent();
	}

    private void btnWeightLoss_Clicked(object sender, EventArgs e)
    {
        btnWeightLoss.BackgroundColor = Color.FromArgb("#e3dfbc");
        btnKeepingFit.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnBuildMuscle.BackgroundColor = Color.FromArgb("#FFFFFF");
        Navigation.PushAsync(new PageStep2());
    }

    private void btnKeepingFit_Clicked(object sender, EventArgs e)
    {
        btnWeightLoss.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnKeepingFit.BackgroundColor = Color.FromArgb("#e3dfbc");
        btnBuildMuscle.BackgroundColor = Color.FromArgb("#FFFFFF");
        Navigation.PushAsync(new PageStep2());
    }

    private void btnBuildMuscle_Clicked(object sender, EventArgs e)
    {
        btnWeightLoss.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnKeepingFit.BackgroundColor = Color.FromArgb("#FFFFFF");
        btnBuildMuscle.BackgroundColor = Color.FromArgb("#e3dfbc");
        Navigation.PushAsync(new PageStep2());
    }
}
```

Описание стилей элементов xaml в **"Styles.xaml"**:
```
<?xml version="1.0" encoding="UTF-8" ?>
<?xaml-comp compile="true" ?>
<ResourceDictionary 
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml">

    <Style TargetType="Label" x:Key="txtStyle">
        <Setter Property="TextColor" Value="White"/>
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="50"/>
        <Setter Property="HorizontalOptions" Value="Center"/>
    </Style>

    <Style TargetType="Label" x:Key="txtStyle2">
        <Setter Property="TextColor" Value="White"/>
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="18"/>
        <Setter Property="HorizontalOptions" Value="Center"/>
    </Style>

    <Style TargetType="Label" x:Key="txtStyle3">
        <Setter Property="TextColor" Value="#6e9cd2"/>
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="18"/>
        <Setter Property="HorizontalOptions" Value="Center"/>
    </Style>

    <Style TargetType="Button" x:Key="btnStyle">
        <Setter Property="TextColor" Value="#6e9cd2"/>
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="25"/>
        <Setter Property="WidthRequest" Value="300"/>
        <Setter Property="HeightRequest" Value="80"/>
        <Setter Property="CornerRadius" Value="40"/>
        <Setter Property="BackgroundColor" Value="White"/>
        <Setter Property="Margin" Value="0,25"/>
        <Setter Property="BorderWidth" Value="0.3"/>
        <Setter Property="BorderColor" Value="Black"/>
    </Style>

    <Style TargetType="Button" x:Key="btnStyle2">
        <Setter Property="TextColor" Value="#6e9cd2"/>
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="16"/>
        <Setter Property="WidthRequest" Value="180"/>
        <Setter Property="HeightRequest" Value="45"/>
        <Setter Property="CornerRadius" Value="20"/>
        <Setter Property="BackgroundColor" Value="White"/>
        <Setter Property="Margin" Value="0,8"/>
        <Setter Property="BorderWidth" Value="0.3"/>
        <Setter Property="BorderColor" Value="Black"/>
    </Style>

    <Style TargetType="Button" x:Key="btnStyle3">
        <Setter Property="WidthRequest" Value="20"/>
        <Setter Property="HeightRequest" Value="20"/>
        <Setter Property="CornerRadius" Value="20"/>
        <Setter Property="BackgroundColor" Value="White"/>
        <Setter Property="BorderWidth" Value="0.3"/>
        <Setter Property="BorderColor" Value="Black"/>
    </Style>

    <Style TargetType="Button" x:Key="btnStyle4">
        <Setter Property="TextColor" Value="#6e9cd2"/>
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="22"/>
        <Setter Property="WidthRequest" Value="300"/>
        <Setter Property="HeightRequest" Value="85"/>
        <Setter Property="CornerRadius" Value="40"/>
        <Setter Property="BackgroundColor" Value="White"/>
        <Setter Property="Margin" Value="0,5"/>
        <Setter Property="BorderWidth" Value="0.6"/>
        <Setter Property="BorderColor" Value="Black"/>
    </Style>

    <Style TargetType="Button" x:Key="btnStyle5">
        <Setter Property="TextColor" Value="#6e9cd2"/>
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="18"/>
        <Setter Property="WidthRequest" Value="250"/>
        <Setter Property="HeightRequest" Value="50"/>
        <Setter Property="BackgroundColor" Value="Transparent"/>
        <Setter Property="BorderWidth" Value="0"/>
    </Style>

    <Style TargetType="Frame" x:Key="frmStyle">
        <Setter Property="WidthRequest" Value="200"/>
        <Setter Property="HeightRequest" Value="55"/>
        <Setter Property="CornerRadius" Value="27"/>
        <Setter Property="BackgroundColor" Value="White"/>
        <Setter Property="Margin" Value="0,5"/>
    </Style>

    <Style TargetType="Frame" x:Key="frmStyle2">
        <Setter Property="WidthRequest" Value="250"/>
        <Setter Property="HeightRequest" Value="70"/>
        <Setter Property="CornerRadius" Value="27"/>
        <Setter Property="BackgroundColor" Value="White"/>
        <Setter Property="Margin" Value="0,5"/>
    </Style>

    <Style TargetType="Rectangle" x:Key="recStyle">
        <Setter Property="WidthRequest" Value="200"/>
        <Setter Property="HeightRequest" Value="55"/>
        <Setter Property="BackgroundColor" Value="White"/>
        <Setter Property="Margin" Value="0,5"/>
    </Style>

    <Style TargetType="Entry" x:Key="entryStyle">
        <Setter Property="TextColor" Value="DarkGray" />
        <Setter Property="PlaceholderColor" Value="Gray" />
        <Setter Property="BackgroundColor" Value="White" />
        <Setter Property="WidthRequest" Value="270"/>
        <Setter Property="HeightRequest" Value="40"/>
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="22" />
    </Style>

    <Style TargetType="ActivityIndicator">
        <Setter Property="Color" Value="{AppThemeBinding Light={StaticResource Primary}, Dark={StaticResource White}}" />
    </Style>

    <Style TargetType="IndicatorView">
        <Setter Property="IndicatorColor" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource Gray500}}"/>
        <Setter Property="SelectedIndicatorColor" Value="{AppThemeBinding Light={StaticResource Gray950}, Dark={StaticResource Gray100}}"/>
    </Style>

    <Style TargetType="Border">
        <Setter Property="Stroke" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource Gray500}}" />
        <Setter Property="StrokeShape" Value="Rectangle"/>
        <Setter Property="StrokeThickness" Value="1"/>
    </Style>

    <Style TargetType="BoxView">
        <Setter Property="Color" Value="{AppThemeBinding Light={StaticResource Gray950}, Dark={StaticResource Gray200}}" />
    </Style>

    <Style TargetType="Button">
        <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource White}, Dark={StaticResource Primary}}" />
        <Setter Property="BackgroundColor" Value="{AppThemeBinding Light={StaticResource Primary}, Dark={StaticResource White}}" />
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="14"/>
        <Setter Property="CornerRadius" Value="8"/>
        <Setter Property="Padding" Value="14,10"/>
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray950}, Dark={StaticResource Gray200}}" />
                            <Setter Property="BackgroundColor" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource Gray600}}" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="CheckBox">
        <Setter Property="Color" Value="{AppThemeBinding Light={StaticResource Primary}, Dark={StaticResource White}}" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="Color" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="DatePicker">
        <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray900}, Dark={StaticResource White}}" />
        <Setter Property="BackgroundColor" Value="Transparent" />
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="14"/>
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource Gray500}}" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="Editor">
        <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Black}, Dark={StaticResource White}}" />
        <Setter Property="BackgroundColor" Value="Transparent" />
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="14" />
        <Setter Property="PlaceholderColor" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource Gray500}}" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="Entry">
        <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Black}, Dark={StaticResource White}}" />
        <Setter Property="BackgroundColor" Value="White" />
        <Setter Property="WidthRequest" Value="280"/>
        <Setter Property="HeightRequest" Value="32"/>
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="14" />
        <Setter Property="PlaceholderColor" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource Gray500}}" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="Frame">
        <Setter Property="HasShadow" Value="False" />
        <Setter Property="BorderColor" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource Gray950}}" />
        <Setter Property="CornerRadius" Value="8" />
    </Style>

    <Style TargetType="ImageButton">
        <Setter Property="Opacity" Value="1" />
        <Setter Property="BorderColor" Value="Transparent"/>
        <Setter Property="BackgroundColor" Value="Transparent"/>
        <Setter Property="BorderWidth" Value="0"/>
        <Setter Property="CornerRadius" Value="0"/>
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="Opacity" Value="0.5" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="Label">
        <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray900}, Dark={StaticResource White}}" />
        <Setter Property="FontFamily" Value="OpenSansRegular" />
        <Setter Property="FontSize" Value="14" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="ListView">
        <Setter Property="SeparatorColor" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource Gray500}}" />
        <Setter Property="RefreshControlColor" Value="{AppThemeBinding Light={StaticResource Gray900}, Dark={StaticResource Gray200}}" />
    </Style>

    <Style TargetType="Picker">
        <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray900}, Dark={StaticResource White}}" />
        <Setter Property="TitleColor" Value="{AppThemeBinding Light={StaticResource Gray900}, Dark={StaticResource Gray200}}" />
        <Setter Property="BackgroundColor" Value="Transparent" />
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="14"/>
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                            <Setter Property="TitleColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="ProgressBar">
        <Setter Property="ProgressColor" Value="{AppThemeBinding Light={StaticResource Primary}, Dark={StaticResource White}}" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="ProgressColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="RadioButton">
        <Setter Property="Background" Value="Transparent"/>
        <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Black}, Dark={StaticResource White}}" />
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="14"/>
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="RefreshView">
        <Setter Property="RefreshColor" Value="{AppThemeBinding Light={StaticResource Gray900}, Dark={StaticResource Gray200}}" />
    </Style>

    <Style TargetType="SearchBar">
        <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray900}, Dark={StaticResource White}}" />
        <Setter Property="PlaceholderColor" Value="{StaticResource Gray500}" />
        <Setter Property="CancelButtonColor" Value="{StaticResource Gray500}" />
        <Setter Property="BackgroundColor" Value="Transparent" />
        <Setter Property="FontFamily" Value="OpenSansRegular" />
        <Setter Property="FontSize" Value="14" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                            <Setter Property="PlaceholderColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="SearchHandler">
        <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray900}, Dark={StaticResource White}}" />
        <Setter Property="PlaceholderColor" Value="{StaticResource Gray500}" />
        <Setter Property="BackgroundColor" Value="Transparent" />
        <Setter Property="FontFamily" Value="OpenSansRegular" />
        <Setter Property="FontSize" Value="14" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                            <Setter Property="PlaceholderColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="Shadow">
        <Setter Property="Radius" Value="15" />
        <Setter Property="Opacity" Value="0.5" />
        <Setter Property="Brush" Value="{AppThemeBinding Light={StaticResource White}, Dark={StaticResource White}}" />
        <Setter Property="Offset" Value="10,10" />
    </Style>

    <Style TargetType="Slider">
        <Setter Property="MinimumTrackColor" Value="{AppThemeBinding Light={StaticResource Primary}, Dark={StaticResource White}}" />
        <Setter Property="MaximumTrackColor" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource Gray600}}" />
        <Setter Property="ThumbColor" Value="{AppThemeBinding Light={StaticResource Primary}, Dark={StaticResource White}}" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="MinimumTrackColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}"/>
                            <Setter Property="MaximumTrackColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}"/>
                            <Setter Property="ThumbColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}"/>
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="SwipeItem">
        <Setter Property="BackgroundColor" Value="{AppThemeBinding Light={StaticResource White}, Dark={StaticResource Black}}" />
    </Style>

    <Style TargetType="Switch">
        <Setter Property="OnColor" Value="{AppThemeBinding Light={StaticResource Primary}, Dark={StaticResource White}}" />
        <Setter Property="ThumbColor" Value="{StaticResource White}" />
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="OnColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                            <Setter Property="ThumbColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                        </VisualState.Setters>
                    </VisualState>
                    <VisualState x:Name="On">
                        <VisualState.Setters>
                            <Setter Property="OnColor" Value="{AppThemeBinding Light={StaticResource Secondary}, Dark={StaticResource Gray200}}" />
                            <Setter Property="ThumbColor" Value="{AppThemeBinding Light={StaticResource Primary}, Dark={StaticResource White}}" />
                        </VisualState.Setters>
                    </VisualState>
                    <VisualState x:Name="Off">
                        <VisualState.Setters>
                            <Setter Property="ThumbColor" Value="{AppThemeBinding Light={StaticResource Gray400}, Dark={StaticResource Gray500}}" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="TimePicker">
        <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray900}, Dark={StaticResource White}}" />
        <Setter Property="Background" Value="Transparent"/>
        <Setter Property="FontFamily" Value="OpenSansRegular"/>
        <Setter Property="FontSize" Value="14"/>
        <Setter Property="VisualStateManager.VisualStateGroups">
            <VisualStateGroupList>
                <VisualStateGroup x:Name="CommonStates">
                    <VisualState x:Name="Normal" />
                    <VisualState x:Name="Disabled">
                        <VisualState.Setters>
                            <Setter Property="TextColor" Value="{AppThemeBinding Light={StaticResource Gray300}, Dark={StaticResource Gray600}}" />
                        </VisualState.Setters>
                    </VisualState>
                </VisualStateGroup>
            </VisualStateGroupList>
        </Setter>
    </Style>

    <Style TargetType="Page" ApplyToDerivedTypes="True">
        <Setter Property="Padding" Value="0"/>
        <Setter Property="BackgroundColor" Value="{AppThemeBinding Light={StaticResource White}, Dark={StaticResource Black}}" />
    </Style>

    <Style TargetType="Shell" ApplyToDerivedTypes="True">
        <Setter Property="Shell.BackgroundColor" Value="{AppThemeBinding Light={StaticResource Primary}, Dark={StaticResource Gray950}}" />
        <Setter Property="Shell.ForegroundColor" Value="{OnPlatform WinUI={StaticResource Primary}, Default={StaticResource White}}" />
        <Setter Property="Shell.TitleColor" Value="{AppThemeBinding Light={StaticResource White}, Dark={StaticResource White}}" />
        <Setter Property="Shell.DisabledColor" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource Gray950}}" />
        <Setter Property="Shell.UnselectedColor" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource Gray200}}" />
        <Setter Property="Shell.NavBarHasShadow" Value="False" />
        <Setter Property="Shell.TabBarBackgroundColor" Value="{AppThemeBinding Light={StaticResource White}, Dark={StaticResource Black}}" />
        <Setter Property="Shell.TabBarForegroundColor" Value="{AppThemeBinding Light={StaticResource Primary}, Dark={StaticResource White}}" />
        <Setter Property="Shell.TabBarTitleColor" Value="{AppThemeBinding Light={StaticResource Primary}, Dark={StaticResource White}}" />
        <Setter Property="Shell.TabBarUnselectedColor" Value="{AppThemeBinding Light={StaticResource Gray900}, Dark={StaticResource Gray200}}" />
    </Style>

    <Style TargetType="NavigationPage">
        <Setter Property="BarBackgroundColor" Value="{AppThemeBinding Light={StaticResource Primary}, Dark={StaticResource Gray950}}" />
        <Setter Property="BarTextColor" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource White}}" />
        <Setter Property="IconColor" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource White}}" />
    </Style>

    <Style TargetType="TabbedPage">
        <Setter Property="BarBackgroundColor" Value="{AppThemeBinding Light={StaticResource White}, Dark={StaticResource Gray950}}" />
        <Setter Property="BarTextColor" Value="{AppThemeBinding Light={StaticResource Primary}, Dark={StaticResource White}}" />
        <Setter Property="UnselectedTabColor" Value="{AppThemeBinding Light={StaticResource Gray200}, Dark={StaticResource Gray950}}" />
        <Setter Property="SelectedTabColor" Value="{AppThemeBinding Light={StaticResource Gray950}, Dark={StaticResource Gray200}}" />
    </Style>

</ResourceDictionary>

```
