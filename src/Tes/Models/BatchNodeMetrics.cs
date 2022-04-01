namespace Tes.Models
{
    /// <summary>
    /// Contains task execution metrics when task is handled by Azure Batch 
    /// </summary>
    public class BatchNodeMetrics
    {
        /// <summary>
        /// Total runtime of task script.
        /// </summary>
        [TesTaskLogMetadataKey("total_script_duration_sec")]
        public double? TotalScriptRuntimeInSeconds { get; set; }

        /// <summary>
        /// Total duration of task preperation before downloading input data.
        /// </summary>
        [TesTaskLogMetadataKey("total_prep_duration_sec")]
        public double? TotalPrepDurationInSeconds { get; set; }

        /// <summary>
        /// Bash install on docker-in-docker container duration
        /// </summary>
        [TesTaskLogMetadataKey("bash_install_duration_sec")]
        public double? BashInstallDurationInSeconds { get; set; }

        /// <summary>
        /// CromwellDrsLocalizer docker image pull duration
        /// </summary>
        [TesTaskLogMetadataKey("drsloc_pull_duration_sec")]
        public double? DrsLocalizerPullDurationInSeconds { get; set; }

        /// <summary>
        /// BlobXfer docker image pull duration
        /// </summary>
        [TesTaskLogMetadataKey("blobxfer_pull_duration_sec")]
        public double? BlobXferImagePullDurationInSeconds { get; set; }

        /// <summary>
        /// Executor docker image pull duration
        /// </summary>
        [TesTaskLogMetadataKey("executor_pull_duration_sec")]
        public double? ExecutorImagePullDurationInSeconds { get; set; }

        /// <summary>
        /// Cromwell DRS localization duration
        /// </summary>
        [TesTaskLogMetadataKey("drsloc_duration_sec")]
        public double? DrsLocalizationDurationInSeconds { get; set; }

        /// <summary>
        /// File download duration
        /// </summary>
        [TesTaskLogMetadataKey("download_duration_sec")]
        public double? FileDownloadDurationInSeconds { get; set; }

        /// <summary>
        /// Set file permissions (chmod) duration
        /// </summary>
        [TesTaskLogMetadataKey("setperms_duration_sec")]
        public double? SetPermissionsDurationInSeconds { get; set; }

        /// <summary>
        /// Main command execution duration
        /// </summary>
        [TesTaskLogMetadataKey("executor_duration_sec")]
        public double? ExecutorDurationInSeconds { get; set; }

        /// <summary>
        /// File upload duration
        /// </summary>
        [TesTaskLogMetadataKey("upload_duration_sec")]
        public double? FileUploadDurationInSeconds { get; set; }

        /// <summary>
        /// Executor image size in GB
        /// </summary>
        [TesTaskLogMetadataKey("executor_image_size_gb")]
        public double? ExecutorImageSizeInGB { get; set; }

        /// <summary>
        /// File download size in GB
        /// </summary>
        [TesTaskLogMetadataKey("file_download_size_gb")]
        public double? FileDownloadSizeInGB { get; set; }

        /// <summary>
        /// File upload size in GB
        /// </summary>
        [TesTaskLogMetadataKey("file_upload_size_gb")]
        public double? FileUploadSizeInGB { get; set; }

        /// <summary>
        /// Local disk file system type
        /// </summary>
        [TesTaskLogMetadataKey("disk_fstype")]
        public string DisFileSystemType { get; set; }

        /// <summary>
        /// Toal disk size in GB
        /// </summary>
        [TesTaskLogMetadataKey("disk_size_gb")]
        public double? DiskSizeInGB { get; set; }

        /// <summary>
        /// Disk space used in GB
        /// </summary>
        [TesTaskLogMetadataKey("disk_used_gb")]
        public double? DiskUsedInGB { get; set; }

        /// <summary>
        /// Max resident memory used in GB
        /// </summary>
        [TesTaskLogMetadataKey("max_res_mem_used_gb")]
        public double? MaxResidentMemoryUsedInGB { get; set; }

        /// <summary>
        /// Disk space used as percent of total
        /// </summary>
        [TesTaskLogMetadataKey("disk_used_pct")]
        public float? DiskUsedPercent { get; set; }

        /// <summary>
        /// Max resident memory used as percent of total
        /// </summary>
        [TesTaskLogMetadataKey("max_res_mem_used_pct")]
        public float? MaxResidentMemoryUsedPercent { get; set; }

        /// <summary>
        /// CPU Model Name
        /// </summary>
        [TesTaskLogMetadataKey("vm_cpu_model_name")]
        public string VmCpuModelName { get; set; }
    }
}
