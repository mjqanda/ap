using Android.Views;
using Android.Views.Animations;

namespace Akyat.Pinas
{
    class MyAnimation : Animation
    {
        private View mView;
        private int mOriginalHeight;
        private int mTargetHeight;
        private int mGrowBy;

        public MyAnimation(View view, int targetHeight)
        {
            mView = view;
            mOriginalHeight = view.Height;
            mTargetHeight = targetHeight;
            mGrowBy = mTargetHeight - mOriginalHeight;
        }

        protected override void ApplyTransformation(float interpolatedTime, Transformation t)
        {
            mView.LayoutParameters.Height = (int)(mOriginalHeight + (mGrowBy * interpolatedTime));
            mView.RequestLayout();
        }

        public override bool WillChangeBounds()
        {
            return true;
        }
    }
}