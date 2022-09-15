# Bamheart (Documentation is a WIP)

Bamheart provides the core set of services for Bam.Net.  Services include:

- UserRegistryService
- ApplicationRegistryService
- ConfigurationService
- DataService  
- PresentationService
- SystemLoggerService
- NotificationService

## UserRegistryService

UserRegistryService implements the interfaces IUserManager, IUserResolver and IRoleResolver.

## ApplicationRegistryService

## ConfigurationService
ConfigurationService implements the interface IConfigurationService.

## DataService

## PresentationService

## SystemLoggerService

SystemLoggerService implements ILog and ILogEventEmitter.  For an ILogger implementation that
logs to the SystemLoggerService use Bam.Net.Services.Clients.CoreLoggerClient.

## NotificationService

NotificationService implements the interface INotficationService.
