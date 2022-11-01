import { IonButtons, IonContent, IonHeader, IonMenuButton, IonPage, IonText, IonTitle, IonToolbar } from '@ionic/react';
import { useParams } from 'react-router';
import './Roles.css';

const Roles: React.FC = () => {

  // const { name } = useParams<{ name: string; }>();

  return (
    <IonPage>
      <IonHeader>
        <IonToolbar>
          <IonButtons slot="start">
            <IonMenuButton />
          </IonButtons>
          <IonTitle>Roles</IonTitle>
        </IonToolbar>
      </IonHeader>

      <IonContent fullscreen>
        <IonHeader collapse="condense">
          <IonToolbar>
            <IonTitle size="large">Roles</IonTitle>
          </IonToolbar>
        </IonHeader>

        <IonContent className='content-padding'>
          <IonTitle>Roles Table</IonTitle>
          <p style={{padding: "5px 20px"}}> Contains list of all roles 👇</p>
        </IonContent>
      </IonContent>
    </IonPage>
  );
};

export default Roles;
