using System;
using test.AssertHelpers;
using test.Model;
using test.Pages.components;
using test.Pages.Components;

namespace test.Steps
{
	public class EducationSteps
    {
        ProfileEducationOverviewComponent ProfileEducationOverviewComponent;
        AddEducationComponent addEducationComponent;

        public EducationSteps() {

            ProfileEducationOverviewComponent =  new ProfileEducationOverviewComponent();
            addEducationComponent = new AddEducationComponent();

        }


		public void addEducation()
		{
			EducationModel education = new EducationModel();
			education.setCountry("New Zealand");
            education.setDegree("Graduate");
            education.setGraduationYear("2015");
            education.setTitle("B.Tech");
            education.setUniversity("Auckand");

            ProfileEducationOverviewComponent.clickAddEducationButton();

            addEducationComponent.addEducation(education);
            String acutalSuccessMessage =addEducationComponent.getSuccessMessage();

            EducationAssertHelper.assertAddEducationSuccessMessage("Education has been added", acutalSuccessMessage);
        }
	}
}

