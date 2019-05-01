/**
 * Sample React Native App
 * https://github.com/facebook/react-native
 *
 * @format
 * @flow
 * @lint-ignore-every XPLATJSCOPYRIGHT1
 */

import Login from './src/components/login/login'
import NewAccount from './src/components/NewAccount/NewAccount'
import Success from './src/components/NewAccount/Success'
import Erro from './src/components/NewAccount/Erro'
import Home from './src/components/Home/Home'
import {createStackNavigator, createAppContainer} from 'react-navigation';

const MainNavigator = createStackNavigator({
  Login: {screen: Login},
  NewAccount: {screen: NewAccount},
  Success: {screen: Success},
  Home: {screen: Home},
  Erro: {screen: Erro}
});

const App = createAppContainer(MainNavigator);

export default App;