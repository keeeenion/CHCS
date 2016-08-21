using System;
using Docker.DotNet;

namespace Kati.Controllers {
	abstract class Docker : Service {

		DockerClient client;

		public string Ip;
		public int Port;

		public Docker(Service service, string ip, int port)
			: base(service.ID, service.Name, service.Owner, service.Description) {
			this.Ip = ip;
			this.Port = port;
		}

		public void Connect() {
			client = new DockerClientConfiguration(new Uri("tcp://"+ Ip +":"+ Port)).CreateClient();
		}

		public void Terminate() {

		}

		public class Container {

			public string ContainerId;

			public Container(String cid) {
				this.ContainerId = cid;
			}

			public void Start() {
				
			}

			public void Stop() {
				
			}

			public void Pause() {
				
			}

			public void Kill() {
				
			}

			public void Delete() {
				
			}
		}

		public class Image {
			
		}
	}
}
