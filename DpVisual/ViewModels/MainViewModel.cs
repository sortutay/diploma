using GeneratingFunctions.Definition;

namespace DpVisual.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private GenFunc1 _firstGen;
        private int _firstCoefParam;
        private int _firstFinalExp;

        private GenFunc2 _secondGen;
        private int _secondExpParam;
        private int _secondFinalExp;

        private GenFunc3 _thirdGen;
        private int _thirdFinalExp;

        private GenFunc4 _fourthGen;
        private int _fourthCoefParam;

        private GenFunc5 _fifthGen;
        private int _fifthFinalExp;

        private GenFunc6 _sixthGen;
        private int _sixthFinalExp;

        public MainViewModel()
        {
            _firstCoefParam = 1;
            _firstFinalExp = 10;
            _firstGen = new GenFunc1(_firstFinalExp, _firstCoefParam);

            _secondExpParam = 1;
            _secondFinalExp = 10;
            _secondGen = new GenFunc2(_secondFinalExp, _secondExpParam);

            _thirdFinalExp = 10;
            _thirdGen = new GenFunc3(_thirdFinalExp);

            _fourthCoefParam = 1;
            _fourthGen = new GenFunc4(_fourthCoefParam);

            _fifthFinalExp = 1;
            _fifthGen = new GenFunc5(_fifthFinalExp);

            _sixthFinalExp = 1;
            _sixthGen = new GenFunc6(_sixthFinalExp);
        }

        #region FirstGeneratingFunction

        public GenFunc1 FirstGen
        {
            get => _firstGen;
            set => SetProperty(ref _firstGen, value);
        }

        public int FirstCoefParam
        {
            get => _firstCoefParam;
            set => SetProperty(ref _firstCoefParam, value);
        }

        public int FirstFinalExp
        {
            get => _firstFinalExp;
            set => SetProperty(ref _firstFinalExp, value);
        }

        public string FirstDef => $"(1 + ax)^n";

        #endregion FirstGeneratingFunction

        #region SecondGeneratingFunction

        public GenFunc2 SecondGen
        {
            get => _secondGen;
            set => SetProperty(ref _secondGen, value);
        }

        public int SecondExpParam
        {
            get => _secondExpParam;
            set => SetProperty(ref _secondExpParam, value);
        }

        public int SecondFinalExp
        {
            get => _secondFinalExp;
            set => SetProperty(ref _secondFinalExp, value);
        }

        public string SecondDef => $"(1 + x^m)^n";

        #endregion SecondGeneratingFunction

        #region ThirdGeneratingFunction

        public GenFunc3 ThirdGen
        {
            get => _thirdGen;
            set => SetProperty(ref _thirdGen, value);
        }

        public int ThirdFinalExp
        {
            get => _thirdFinalExp;
            set => SetProperty(ref _thirdFinalExp, value);
        }

        public string ThirdDef => $"(1 - x^(n + 1)) / (1 - x)";

        #endregion ThirdGeneratingFunction

        #region FourthGeneratingFunction

        public GenFunc4 FourthGen
        {
            get => _fourthGen;
            set => SetProperty(ref _fourthGen, value);
        }

        public int FourthCoefParam
        {
            get => _fourthCoefParam;
            set => SetProperty(ref _fourthCoefParam, value);
        }

        public string FourthDef => $"1 / (1 - ax)";

        #endregion FourthGeneratingFunction

        #region FifthGeneratingFunction

        public GenFunc5 FifthGen
        {
            get => _fifthGen;
            set => SetProperty(ref _fifthGen, value);
        }

        public int FifthFinalExp
        {
            get => _fifthFinalExp;
            set => SetProperty(ref _fifthFinalExp, value);
        }

        public string FifthDef => $"1 / (1 + x)^n";

        #endregion FifthGeneratingFunction

        #region SixthGeneratingFunction

        public GenFunc6 SixthGen
        {
            get => _sixthGen;
            set => SetProperty(ref _sixthGen, value);
        }

        public int SixthFinalExp
        {
            get => _sixthFinalExp;
            set => SetProperty(ref _sixthFinalExp, value);
        }

        public string SixthDef => $"1 / (1 - x)^n";

        #endregion SixthGeneratingFunction
    }
}