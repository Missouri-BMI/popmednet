namespace Lpp.Dns.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreDataMartChecboxes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DataMarts", "LaboratoryResultsSpecimenSource", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "LaboratoryResultsTestDescriptions", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "LaboratoryResultsOrderDates", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "InpatientDatesOfService", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "InpatientICD9Procedures", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "InpatientICD10Procedures", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "InpatientICD9Diagnosis", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "InpatientICD10Diagnosis", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "InpatientSNOMED", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "InpatientHPHCS", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "InpatientDisposition", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "InpatientDischargeStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "InpatientOther", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "InpatientOtherText", c => c.String(maxLength: 80));
            AddColumn("dbo.DataMarts", "OutpatientClinicalSetting", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "OutpatientDatesOfService", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "OutpatientICD9Procedures", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "OutpatientICD10Procedures", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "OutpatientICD9Diagnosis", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "OutpatientICD10Diagnosis", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "OutpatientSNOMED", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "OutpatientHPHCS", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "OutpatientOther", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "OutpatientOtherText", c => c.String(maxLength: 80));
            AddColumn("dbo.DataMarts", "ERPatientID", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "EREncounterID", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "EREnrollmentDates", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "EREncounterDates", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "ERClinicalSetting", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "ERICD9Diagnosis", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "ERICD10Diagnosis", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "ERHPHCS", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "ERNDC", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "ERSNOMED", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "ERProviderIdentifier", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "ERProviderFacility", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "EREncounterType", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "ERDRG", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "ERDRGType", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "EROther", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "EROtherText", c => c.String(maxLength: 80));
            AddColumn("dbo.DataMarts", "DemographicsPatientID", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "DemographicsSex", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "DemographicsDateOfBirth", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "DemographicsDateOfDeath", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "DemographicsAddressInfo", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "DemographicsRace", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "DemographicsEthnicity", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "DemographicsOtherText", c => c.String(maxLength: 80));
            AddColumn("dbo.DataMarts", "PatientOutcomesInstruments", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PatientOutcomesInstrumentText", c => c.String(maxLength: 80));
            AddColumn("dbo.DataMarts", "PatientOutcomesHealthBehavior", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PatientOutcomesHRQoL", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PatientOutcomesReportedOutcome", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PatientOutcomesOther", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PatientOutcomesOtherText", c => c.String(maxLength: 80));
            AddColumn("dbo.DataMarts", "PatientBehaviorHealthBehavior", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PatientBehaviorInstruments", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PatientBehaviorInstrumentText", c => c.String(maxLength: 80));
            AddColumn("dbo.DataMarts", "PatientBehaviorOther", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PatientBehaviorOtherText", c => c.String(maxLength: 80));
            AddColumn("dbo.DataMarts", "VitalSignsTemperature", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "VitalSignsHeight", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "VitalSignsWeight", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "VitalSignsBMI", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "VitalSignsBloodPressure", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "VitalSignsOther", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "VitalSignsOtherText", c => c.String(maxLength: 80));
            AddColumn("dbo.DataMarts", "PrescriptionOrderDates", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PrescriptionOrderRxNorm", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PrescriptionOrderNDC", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PrescriptionOrderOther", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PrescriptionOrderOtherText", c => c.String(maxLength: 80));
            AddColumn("dbo.DataMarts", "PharmacyDispensingDates", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PharmacyDispensingRxNorm", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PharmacyDispensingDaysSupply", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PharmacyDispensingAmountDispensed", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PharmacyDispensingNDC", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PharmacyDispensingOther", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PharmacyDispensingOtherText", c => c.String(maxLength: 80));
            AddColumn("dbo.DataMarts", "BiorepositoriesName", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "BiorepositoriesDescription", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "BiorepositoriesDiseaseName", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "BiorepositoriesSpecimenSource", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "BiorepositoriesSpecimenType", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "BiorepositoriesProcessingMethod", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "BiorepositoriesSNOMED", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "BiorepositoriesStorageMethod", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "BiorepositoriesOther", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "BiorepositoriesOtherText", c => c.String(maxLength: 80));
            DropColumn("dbo.DataMarts", "InpatientClaims");
            DropColumn("dbo.DataMarts", "OutpatientClaims");
            DropColumn("dbo.DataMarts", "OutpatientPharmacyClaims");
            DropColumn("dbo.DataMarts", "EnrollmentClaims");
            DropColumn("dbo.DataMarts", "DemographicsClaims");
            DropColumn("dbo.DataMarts", "VitalSignsClaims");
            DropColumn("dbo.DataMarts", "BiorepositoriesClaims");
            DropColumn("dbo.DataMarts", "PatientReportedOutcomesClaims");
            DropColumn("dbo.DataMarts", "PatientReportedBehaviorsClaims");
            DropColumn("dbo.DataMarts", "PrescriptionOrdersClaims");
            DropColumn("dbo.DataMarts", "PharmacyDispensingClaims");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DataMarts", "PharmacyDispensingClaims", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PrescriptionOrdersClaims", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PatientReportedBehaviorsClaims", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "PatientReportedOutcomesClaims", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "BiorepositoriesClaims", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "VitalSignsClaims", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "DemographicsClaims", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "EnrollmentClaims", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "OutpatientPharmacyClaims", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "OutpatientClaims", c => c.Boolean(nullable: false));
            AddColumn("dbo.DataMarts", "InpatientClaims", c => c.Boolean(nullable: false));
            DropColumn("dbo.DataMarts", "BiorepositoriesOtherText");
            DropColumn("dbo.DataMarts", "BiorepositoriesOther");
            DropColumn("dbo.DataMarts", "BiorepositoriesStorageMethod");
            DropColumn("dbo.DataMarts", "BiorepositoriesSNOMED");
            DropColumn("dbo.DataMarts", "BiorepositoriesProcessingMethod");
            DropColumn("dbo.DataMarts", "BiorepositoriesSpecimenType");
            DropColumn("dbo.DataMarts", "BiorepositoriesSpecimenSource");
            DropColumn("dbo.DataMarts", "BiorepositoriesDiseaseName");
            DropColumn("dbo.DataMarts", "BiorepositoriesDescription");
            DropColumn("dbo.DataMarts", "BiorepositoriesName");
            DropColumn("dbo.DataMarts", "PharmacyDispensingOtherText");
            DropColumn("dbo.DataMarts", "PharmacyDispensingOther");
            DropColumn("dbo.DataMarts", "PharmacyDispensingNDC");
            DropColumn("dbo.DataMarts", "PharmacyDispensingAmountDispensed");
            DropColumn("dbo.DataMarts", "PharmacyDispensingDaysSupply");
            DropColumn("dbo.DataMarts", "PharmacyDispensingRxNorm");
            DropColumn("dbo.DataMarts", "PharmacyDispensingDates");
            DropColumn("dbo.DataMarts", "PrescriptionOrderOtherText");
            DropColumn("dbo.DataMarts", "PrescriptionOrderOther");
            DropColumn("dbo.DataMarts", "PrescriptionOrderNDC");
            DropColumn("dbo.DataMarts", "PrescriptionOrderRxNorm");
            DropColumn("dbo.DataMarts", "PrescriptionOrderDates");
            DropColumn("dbo.DataMarts", "VitalSignsOtherText");
            DropColumn("dbo.DataMarts", "VitalSignsOther");
            DropColumn("dbo.DataMarts", "VitalSignsBloodPressure");
            DropColumn("dbo.DataMarts", "VitalSignsBMI");
            DropColumn("dbo.DataMarts", "VitalSignsWeight");
            DropColumn("dbo.DataMarts", "VitalSignsHeight");
            DropColumn("dbo.DataMarts", "VitalSignsTemperature");
            DropColumn("dbo.DataMarts", "PatientBehaviorOtherText");
            DropColumn("dbo.DataMarts", "PatientBehaviorOther");
            DropColumn("dbo.DataMarts", "PatientBehaviorInstrumentText");
            DropColumn("dbo.DataMarts", "PatientBehaviorInstruments");
            DropColumn("dbo.DataMarts", "PatientBehaviorHealthBehavior");
            DropColumn("dbo.DataMarts", "PatientOutcomesOtherText");
            DropColumn("dbo.DataMarts", "PatientOutcomesOther");
            DropColumn("dbo.DataMarts", "PatientOutcomesReportedOutcome");
            DropColumn("dbo.DataMarts", "PatientOutcomesHRQoL");
            DropColumn("dbo.DataMarts", "PatientOutcomesHealthBehavior");
            DropColumn("dbo.DataMarts", "PatientOutcomesInstrumentText");
            DropColumn("dbo.DataMarts", "PatientOutcomesInstruments");
            DropColumn("dbo.DataMarts", "DemographicsOtherText");
            DropColumn("dbo.DataMarts", "DemographicsEthnicity");
            DropColumn("dbo.DataMarts", "DemographicsRace");
            DropColumn("dbo.DataMarts", "DemographicsAddressInfo");
            DropColumn("dbo.DataMarts", "DemographicsDateOfDeath");
            DropColumn("dbo.DataMarts", "DemographicsDateOfBirth");
            DropColumn("dbo.DataMarts", "DemographicsSex");
            DropColumn("dbo.DataMarts", "DemographicsPatientID");
            DropColumn("dbo.DataMarts", "EROtherText");
            DropColumn("dbo.DataMarts", "EROther");
            DropColumn("dbo.DataMarts", "ERDRGType");
            DropColumn("dbo.DataMarts", "ERDRG");
            DropColumn("dbo.DataMarts", "EREncounterType");
            DropColumn("dbo.DataMarts", "ERProviderFacility");
            DropColumn("dbo.DataMarts", "ERProviderIdentifier");
            DropColumn("dbo.DataMarts", "ERSNOMED");
            DropColumn("dbo.DataMarts", "ERNDC");
            DropColumn("dbo.DataMarts", "ERHPHCS");
            DropColumn("dbo.DataMarts", "ERICD10Diagnosis");
            DropColumn("dbo.DataMarts", "ERICD9Diagnosis");
            DropColumn("dbo.DataMarts", "ERClinicalSetting");
            DropColumn("dbo.DataMarts", "EREncounterDates");
            DropColumn("dbo.DataMarts", "EREnrollmentDates");
            DropColumn("dbo.DataMarts", "EREncounterID");
            DropColumn("dbo.DataMarts", "ERPatientID");
            DropColumn("dbo.DataMarts", "OutpatientOtherText");
            DropColumn("dbo.DataMarts", "OutpatientOther");
            DropColumn("dbo.DataMarts", "OutpatientHPHCS");
            DropColumn("dbo.DataMarts", "OutpatientSNOMED");
            DropColumn("dbo.DataMarts", "OutpatientICD10Diagnosis");
            DropColumn("dbo.DataMarts", "OutpatientICD9Diagnosis");
            DropColumn("dbo.DataMarts", "OutpatientICD10Procedures");
            DropColumn("dbo.DataMarts", "OutpatientICD9Procedures");
            DropColumn("dbo.DataMarts", "OutpatientDatesOfService");
            DropColumn("dbo.DataMarts", "OutpatientClinicalSetting");
            DropColumn("dbo.DataMarts", "InpatientOtherText");
            DropColumn("dbo.DataMarts", "InpatientOther");
            DropColumn("dbo.DataMarts", "InpatientDischargeStatus");
            DropColumn("dbo.DataMarts", "InpatientDisposition");
            DropColumn("dbo.DataMarts", "InpatientHPHCS");
            DropColumn("dbo.DataMarts", "InpatientSNOMED");
            DropColumn("dbo.DataMarts", "InpatientICD10Diagnosis");
            DropColumn("dbo.DataMarts", "InpatientICD9Diagnosis");
            DropColumn("dbo.DataMarts", "InpatientICD10Procedures");
            DropColumn("dbo.DataMarts", "InpatientICD9Procedures");
            DropColumn("dbo.DataMarts", "InpatientDatesOfService");
            DropColumn("dbo.DataMarts", "LaboratoryResultsOrderDates");
            DropColumn("dbo.DataMarts", "LaboratoryResultsTestDescriptions");
            DropColumn("dbo.DataMarts", "LaboratoryResultsSpecimenSource");
        }
    }
}