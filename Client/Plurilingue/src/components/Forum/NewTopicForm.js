//import liraries
import React, { Component } from 'react';
import { View, Text, StyleSheet, Dimensions} from 'react-native';
import { Container, Header, Content, Form, Item, Input, Label, Icon, Button, Textarea } from 'native-base';
import axios from 'axios';

// create a component
const {width: WIDTH} = Dimensions.get('window')
const {height: HEIGHT} = Dimensions.get('window')
class NewTopicForm extends Component {
    constructor(){
        super()
        this.state ={
            User_id:'',
            Title:'',
            Language:'',
            TextContent:''
        }
    }

    submit(userId){

        axios({
            url: 'http://10.0.2.2:5000/v1/forum/AddQuestion',
            method: 'post',
            data: {
                User_id: userId,
                Title: this.state.Title,
                Language: this.state.Language,
                TextContent: this.state.TextContent
            },
            headers: {
              Accept: 'application/json',
              'Content-Type': 'application/json',
            }
          })
          .then(response => {
            this.props.navigation.navigate('Forum');
          })
          .catch(error => {
            
          });
      
      }

    render() {
        const { navigation } = this.props;
        const userId = navigation.getParam('userId');
        return (
            <Container>
                <Content>
                    <Form style={{marginTop: 50}}>
                        <Item rounded>
                            <Input placeholder='Title' 
                                onChangeText={value=> this.setState({ Title: value})} 
                                value={this.state.Title} />
                        </Item>
                        <Item rounded>
                            <Input placeholder='Language'
                                onChangeText={value=> this.setState({ Language: value})} 
                                value={this.state.Language} />
                        </Item>

                        <Textarea rowSpan={5} bordered placeholder='Textarea' 
                            onChangeText={value=> this.setState({ TextContent: value})} 
                            value={this.state.TextContent} />

                    </Form>
                    <Button block danger onPress={() => this.submit(userId)} style={{width: WIDTH - 100, marginTop: 60, justifyContent: 'center', left: 50}}>
                        <Text style={{fontSize: 18, color: 'white', fontWeight: 'bold'}}>Post Your Question</Text>
                    </Button>
                </Content>
            </Container>
        );
    }
}

// define your styles
const styles = StyleSheet.create({
    container: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: '#fff',
    },
});

//make this component available to the app
export default NewTopicForm;
