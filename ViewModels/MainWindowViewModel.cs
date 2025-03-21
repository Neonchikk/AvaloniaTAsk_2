using ReactiveUI;
using System;
using System.Reactive;

namespace BasicMvvmSample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        // Свойства для точки
        private double _pointX;
        public double PointX
        {
            get => _pointX;
            set => this.RaiseAndSetIfChanged(ref _pointX, value);
        }

        private double _pointY;
        public double PointY
        {
            get => _pointY;
            set => this.RaiseAndSetIfChanged(ref _pointY, value);
        }

        private string _pointResult = string.Empty; // Инициализация
        public string PointResult
        {
            get => _pointResult;
            set => this.RaiseAndSetIfChanged(ref _pointResult, value);
        }

        // Свойства для линии
        private double _lineLength;
        public double LineLength
        {
            get => _lineLength;
            set => this.RaiseAndSetIfChanged(ref _lineLength, value);
        }

        private string _lineResult = string.Empty; // Инициализация
        public string LineResult
        {
            get => _lineResult;
            set => this.RaiseAndSetIfChanged(ref _lineResult, value);
        }

        // Свойства для эллипса
        private double _ellipseMajorAxis;
        public double EllipseMajorAxis
        {
            get => _ellipseMajorAxis;
            set => this.RaiseAndSetIfChanged(ref _ellipseMajorAxis, value);
        }

        private double _ellipseMinorAxis;
        public double EllipseMinorAxis
        {
            get => _ellipseMinorAxis;
            set => this.RaiseAndSetIfChanged(ref _ellipseMinorAxis, value);
        }

        private string _ellipseResult = string.Empty; // Инициализация
        public string EllipseResult
        {
            get => _ellipseResult;
            set => this.RaiseAndSetIfChanged(ref _ellipseResult, value);
        }

        // Свойства для прямоугольника
        private double _rectangleWidth;
        public double RectangleWidth
        {
            get => _rectangleWidth;
            set => this.RaiseAndSetIfChanged(ref _rectangleWidth, value);
        }

        private double _rectangleHeight;
        public double RectangleHeight
        {
            get => _rectangleHeight;
            set => this.RaiseAndSetIfChanged(ref _rectangleHeight, value);
        }

        private string _rectangleResult = string.Empty; // Инициализация
        public string RectangleResult
        {
            get => _rectangleResult;
            set => this.RaiseAndSetIfChanged(ref _rectangleResult, value);
        }

        // Команды
        public ReactiveCommand<Unit, Unit> CalculatePointCommand { get; }
        public ReactiveCommand<Unit, Unit> CalculateLineCommand { get; }
        public ReactiveCommand<Unit, Unit> CalculateEllipseCommand { get; }
        public ReactiveCommand<Unit, Unit> CalculateRectangleCommand { get; }

        public MainWindowViewModel()
        {
            // Инициализация команд
            CalculatePointCommand = ReactiveCommand.Create(CalculatePoint);
            CalculateLineCommand = ReactiveCommand.Create(CalculateLine);
            CalculateEllipseCommand = ReactiveCommand.Create(CalculateEllipse);
            CalculateRectangleCommand = ReactiveCommand.Create(CalculateRectangle);
        }

        private void CalculatePoint()
        {
            PointResult = $"Point coordinates: ({PointX}, {PointY})";
        }

        private void CalculateLine()
        {
            LineResult = $"Line length: {LineLength}";
        }

        private void CalculateEllipse()
        {
            double area = Math.PI * EllipseMajorAxis * EllipseMinorAxis;
            EllipseResult = $"Ellipse area: {area:F2}";
        }

        private void CalculateRectangle()
        {
            double area = RectangleWidth * RectangleHeight;
            RectangleResult = $"Rectangle area: {area:F2}";
        }
    }
}
