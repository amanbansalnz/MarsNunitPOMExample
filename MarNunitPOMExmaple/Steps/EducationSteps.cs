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
        AddAndUpdateEducationComponent addAndUpdateEducationComponent;

        public EducationSteps() {

            ProfileEducationOverviewComponent =  new ProfileEducationOverviewComponent();
            addAndUpdateEducationComponent = new AddAndUpdateEducationComponent();

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

            addAndUpdateEducationComponent.addEducation(education);
            String acutalSuccessMessage = addAndUpdateEducationComponent.getSuccessMessage();

            EducationAssertHelper.assertAddEducationSuccessMessage("Education has been added", acutalSuccessMessage);
        }
	}
}

