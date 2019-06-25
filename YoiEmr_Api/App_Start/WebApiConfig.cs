using System.Linq;
using System.Web.Http;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.OData.Edm;
using Yoisoft.Application.HospitalOrganization.User;
using Yoisoft.Application.Base;
using Yoisoft.Application.HospitalOrganization.DepartmentAndWard;
using Yoisoft.Application.Patient;
using Yoisoft.Application.Patient.Patient;

namespace YoiEmr_Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                  name: "DefaultApi",
                  routeTemplate: "api/{controller}/{action}/{id}",
                  defaults: new { id = RouteParameter.Optional }


              );

            //6.0 版本之后需要添加这句话
            //odata路由  
            //config.MapODataServiceRoute(
            //               routeName: "Odata",
            //               routePrefix: "Api",
            //               model: GetEdmModel());

            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);
            // config.AddODataQueryFilter();
            config.MapODataServiceRoute(routeName: "odata route", routePrefix: "odata", model: GetEdmModel());
        }



        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            var prefixstr = "";
            builder.EntitySet<UserEntity>(prefixstr + "User");
            builder.EntitySet<PatientEntity>(prefixstr + "Patient");


            builder.EntityType<PatientEntity>().Collection
                .Function("RecordQuery")
                .Returns<IQueryable<PatientEntity>>();




            builder.EntitySet<DeptAndWardEntity>(prefixstr + "DepartmentAndWard");

            //Base CODE
            builder.EntitySet<CODE_BASICEntity>(prefixstr + "CODE_BASIC");
            builder.EntitySet<CODE_AREAEntity>(prefixstr + "CODE_AREA");
            builder.EntitySet<CODE_CAREEREntity>(prefixstr + "CODE_CAREER");
            builder.EntitySet<CODE_CASE_HISTORYSTYPEEntity>(prefixstr + "CODE_CASE_HISTORYSTYPE");
            builder.EntitySet<CODE_DOCUMENTEntity>(prefixstr + "CODE_DOCUMENT");
            builder.EntitySet<CODE_FAMILYRELATIONEntity>(prefixstr + "CODE_FAMILYRELATION");
            builder.EntitySet<CODE_FEEEntity>(prefixstr + "CODE_FEE");
            builder.EntitySet<CODE_FREQUENCYEntity>(prefixstr + "CODE_FREQUENCY");
            builder.EntitySet<CODE_ITEMEntity>(prefixstr + "CODE_ITEM");
            builder.EntitySet<CODE_MARRIAGEEntity>(prefixstr + "CODE_MARRIAGE");
            builder.EntitySet<CODE_NAPARAMETEREntity>(prefixstr + "CODE_NAPARAMETER");
            builder.EntitySet<CODE_NATIONALITYEntity>(prefixstr + "CODE_NATIONALITY");
            builder.EntitySet<CODE_ORGANEntity>(prefixstr + "CODE_ORGAN");
            builder.EntitySet<CODE_PATIENTSOURCEEntity>(prefixstr + "CODE_PATIENTSOURCE");
            builder.EntitySet<CODE_POSTEntity>(prefixstr + "CODE_POST");
            builder.EntitySet<CODE_POSTLEVELEntity>(prefixstr + "CODE_POSTLEVEL");
            builder.EntitySet<CODE_PROVANDCITYEntity>(prefixstr + "CODE_PROVANDCITY");
            builder.EntitySet<CODE_RACEEntity>(prefixstr + "CODE_RACE");
            builder.EntitySet<CODE_SCHOOLEntity>(prefixstr + "CODE_SCHOOL");
            builder.EntitySet<CODE_SEXEntity>(prefixstr + "CODE_SEX");
            builder.EntitySet<CODE_STATEEntity>(prefixstr + "CODE_STATE");
            builder.EntitySet<CODE_TITLEEntity>(prefixstr + "CODE_TITLE");
            builder.EntitySet<CODE_VISITDEPTEntity>(prefixstr + "CODE_VISITDEPT");
            builder.EntitySet<DXCODE_DXEntity>(prefixstr + "DXCODE_DX");
            builder.EntitySet<Record_typeEntity>(prefixstr + "Record_type");
            builder.EntitySet<RecordReviewEntity>(prefixstr + "RecordReview");
            builder.EntitySet<SYS_REPORTCARDEntity>(prefixstr + "SYS_REPORTCARD");
            builder.EntitySet<SYS_RIGHTBAREntity>(prefixstr + "SYS_RIGHTBAR");
            builder.EntitySet<TemplatesEntity>(prefixstr + "Templates");
            //DOC
            builder.EntitySet<AdmiSsionRecordEntity>(prefixstr + "AdmiSsionRecord");
            builder.EntityType<AdmiSsionRecordEntity>().Collection
               .Function("RecordQuery")
               .Returns<IQueryable<AdmiSsionRecordEntity>>();
            builder.EntitySet<ConsultationEntity>(prefixstr + "Consultation");
            builder.EntitySet<DeathRecordEntity>(prefixstr + "DeathRecord");
            builder.EntitySet<DepartTransEntity>(prefixstr + "DepartTrans");
            builder.EntitySet<DischargeRecordEntity>(prefixstr + "DischargeRecord");
            builder.EntitySet<DOCTORS_24DEATH_RECORDEntity>(prefixstr + "DOCTORS_24DEATH_RECORD");
            builder.EntitySet<DoctorsOperationEntity>(prefixstr + "DoctorsOperation");
            builder.EntitySet<InformedConsentContentEntity>(prefixstr + "InformedConsentContent");
            builder.EntitySet<InformedConsentTemplateEntity>(prefixstr + "InformedConsentTemplate");
            builder.EntitySet<InOutHosRecordEntity>(prefixstr + "InOutHosRecord");
            builder.EntitySet<PerioperativeEntity>(prefixstr + "Perioperative");
            builder.EntitySet<progress_noteEntity>(prefixstr + "progress_note");
            builder.EntitySet<AdmissionAssessmentEntity>(prefixstr + "AdmissionAssessment");
            builder.EntitySet<CatheterEvaluationEntity>(prefixstr + "CatheterEvaluation");
            builder.EntitySet<CNREntity>(prefixstr + "CNR");
            builder.EntitySet<DischargeAssessmentEntity>(prefixstr + "DischargeAssessment");
            builder.EntitySet<NIHSSScoreEntity>(prefixstr + "NIHSSScore");
            builder.EntitySet<NURSE_CONSULTATIONEntity>(prefixstr + "NURSE_CONSULTATION");
            builder.EntitySet<NURSE_THERMOMETER_RECORDEntity>(prefixstr + "NURSE_THERMOMETER_RECORD");
            builder.EntitySet<NURSE_THERMOMETEREntity>(prefixstr + "NURSE_THERMOMETER");
            builder.EntitySet<PainScoreEntity>(prefixstr + "PainScore");
            builder.EntitySet<ADLScoreEntity>(prefixstr + "ADLScore");
            builder.EntitySet<BradenScoreEntity>(prefixstr + "BradenScore");
            builder.EntitySet<FallScoreEntity>(prefixstr + "FallScore");
            builder.EntitySet<DiagnosisEntity>(prefixstr + "Diagnosis");
            //PATIENT
            builder.EntitySet<MedicalRecordHomepageEntity>(prefixstr + "MedicalRecordHomepage");
            return builder.GetEdmModel();
        }

    }
}
